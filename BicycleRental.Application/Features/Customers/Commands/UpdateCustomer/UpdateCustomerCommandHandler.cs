using AutoMapper;
using BicycleRental.Application.Exceptions;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {

            var customerToUpdate = await _customerRepository.GetByIdAsync(request.CustomerID);

            if (customerToUpdate == null)
            {
                throw new NotFoundException(nameof(Address), request.CustomerID);
            }

            var validator = new UpdateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            
            customerToUpdate.CustomerAdressID = request.CustomerAdressID;
            customerToUpdate.Firstname = request.Firstname;
            customerToUpdate.Lastname = request.Lastname;

            await _customerRepository.UpdateAsync(customerToUpdate);

            

            return Unit.Value;
        }
    }
}
