using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrderDetail
{
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailVm>
    {
        private readonly IAsyncRepository<Bicycle> _bicycleRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public GetOrderDetailQueryHandler(IMapper mapper, IAsyncRepository<Bicycle> bicycleRepository, IOrderRepository orderRepository, IAsyncRepository<Customer> customerRepositor)
        {
            _mapper = mapper;
            _bicycleRepository = bicycleRepository;
            _orderRepository = orderRepository;
            _customerRepository = customerRepositor;
        }

        public async Task<OrderDetailVm> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {

            var order = await _orderRepository.GetByCompositeKeyId(request.CustomerID, request.BicycleID);

            //var customer = await _customerRepository.GetByIdAsync(order.CustomerID);
            //var bicycle = await _bicycleRepository.GetByIdAsync(order.BicycleID);

            order.Bicycle = await _bicycleRepository.GetByIdAsync(order.BicycleID);
            order.Customer = await _customerRepository.GetByIdAsync(order.CustomerID);


            var orderDetailDTO = _mapper.Map<OrderDetailVm>(order);
            orderDetailDTO.BicycleDto = _mapper.Map<BicycleDto>(order.Bicycle);
            orderDetailDTO.CustomerDto = _mapper.Map<CustomerDto>(order.Customer);

            return orderDetailDTO;
        }
    }
}

