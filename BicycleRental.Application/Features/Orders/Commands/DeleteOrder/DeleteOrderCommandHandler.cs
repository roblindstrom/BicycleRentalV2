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
        private readonly IAsyncRepository<Order> _orderRepository;
        

        public DeleteOrderCommandHandler(IAsyncRepository<Order> customerRepository)
        {
            
            _orderRepository = customerRepository;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var customerToDelete = await _orderRepository.GetByIdAsync(request.BicycleID);

            await _orderRepository.DeleteAsync(customerToDelete);

            return Unit.Value;
        }
    }
}
