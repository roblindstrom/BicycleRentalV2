using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrdersListVm>>
    {
        private readonly IAsyncRepository<Order> _orderRepository;
        private readonly IMapper _mapper;
        public GetOrdersListQueryHandler(IMapper mapper, IAsyncRepository<Order> orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;

        }

        //Get all Orders and show them by list
        public async Task<List<OrdersListVm>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            var allOrders = (await _orderRepository.ListAllAsync()).OrderBy(x => x.CustomerID);
            return _mapper.Map<List<OrdersListVm>>(allOrders);
        }
    }
}
