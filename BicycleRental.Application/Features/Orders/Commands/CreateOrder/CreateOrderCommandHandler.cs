using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            var createOrderCommandResponse = new CreateOrderCommandResponse();

            var validator = new CreateOrderCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createOrderCommandResponse.Success = false;
                createOrderCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createOrderCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createOrderCommandResponse.Success)
            {
                var order = new Order() { CustomerID = request.CustomerID };
                order = await _orderRepository.AddAsync(order);
                createOrderCommandResponse.OrderDto = _mapper.Map<CreateOrderDto>(order);
            }

            return createOrderCommandResponse;
        }
    }
}
