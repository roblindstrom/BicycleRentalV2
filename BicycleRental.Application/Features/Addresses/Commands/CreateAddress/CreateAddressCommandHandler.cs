using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, CreateAddressCommandResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IMapper mapper, IAddressRepository addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var createAddressCommandResponse = new CreateAddressCommandResponse();

            var validator = new CreateAddressCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createAddressCommandResponse.Success = false;
                createAddressCommandResponse.ValidationErrors = new List<string>();

                foreach (var error in validationResult.Errors)
                {
                    createAddressCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }

            }
            if (createAddressCommandResponse.Success)
            {
                var address = new Address() { 
                    AddressID = request.AddressID,
                    AddressName = request.AddressName
                };
                address = await _addressRepository.AddAsync(address);
                createAddressCommandResponse.AddressDto = _mapper.Map<CreateAddressDto>(address);
            }


            return createAddressCommandResponse;
        }
    }
}

