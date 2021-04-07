using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly IAsyncRepository<Customer> _customerRepository;
        

        public DeleteCustomerCommandHandler(IAsyncRepository<Customer> customerRepository)
        {
            
            _customerRepository = customerRepository;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerToDelete = await _customerRepository.GetByIdAsync(request.CustomerID);

            await _customerRepository.DeleteAsync(customerToDelete);

            return Unit.Value;
        }
    }
}
