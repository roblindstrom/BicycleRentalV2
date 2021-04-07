using AutoMapper;
using BicycleRental.Application.Exceptions;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Orders.Commands.UpdateOrder
{
    class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {

            var orderToUpdate = await _orderRepository.GetByIdAsync(request.BicycleID);

            if (orderToUpdate == null)
            {
                throw new NotFoundException(nameof(Address), request.BicycleID);
            }

            var validator = new UpdateOrderCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            
            orderToUpdate.CustomerID = request.CustomerID;
            orderToUpdate.BicycleID = request.BicycleID;
            orderToUpdate.BookingStartDate = request.BookingStartDate;
            orderToUpdate.BookingEndDate = request.BookingEndDate;

            await _orderRepository.UpdateAsync(orderToUpdate);

            return Unit.Value;
        }
    }
}
