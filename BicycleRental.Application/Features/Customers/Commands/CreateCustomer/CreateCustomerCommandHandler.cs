using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerCommandResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var createCustomerCommandResponse = new CreateCustomerCommandResponse();

            var validator = new CreateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createCustomerCommandResponse.Success = false;
                createCustomerCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createCustomerCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createCustomerCommandResponse.Success)
            {
                var Customer = new Customer() { 
                    CustomerID = request.CustomerID,
                    Firstname = request.Firstname,
                    Lastname = request.Lastname,
                    CustomerAdressID = request.CustomerAdressID
                };
                Customer = await _customerRepository.AddAsync(Customer);
                createCustomerCommandResponse.CustomerDto = _mapper.Map<CreateCustomerDto>(Customer);
            }



            return createCustomerCommandResponse;
        }
    }
}
