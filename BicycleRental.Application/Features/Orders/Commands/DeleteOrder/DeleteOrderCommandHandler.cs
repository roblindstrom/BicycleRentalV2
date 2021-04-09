using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        

        public DeleteOrderCommandHandler(IOrderRepository orderRepository)
        {
            
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var customerToDelete = await _orderRepository.GetByCompositeKeyId(request.CustomerID, request.BicycleID);

            await _orderRepository.DeleteAsync(customerToDelete);

            return Unit.Value;
        }
    }
}
