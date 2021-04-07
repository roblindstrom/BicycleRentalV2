using AutoMapper;
using BicycleRental.Application.Exceptions;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Addresses.Commands.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
    {
        private readonly IAsyncRepository<Address> _addressRepository;
        private readonly IMapper _mapper;

        public UpdateAddressCommandHandler(IMapper mapper, IAddressRepository addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {

            var addressToUpdate = await _addressRepository.GetByIdAsync(request.AddressID);

            if (addressToUpdate == null)
            {
                throw new NotFoundException(nameof(Address), request.AddressID);
            }

            var validator = new UpdateAddressCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            addressToUpdate.AddressID = request.AddressID;
            addressToUpdate.AddressName = request.AddressName;

            await _addressRepository.UpdateAsync(addressToUpdate);

            return Unit.Value;
        }
    }
}
