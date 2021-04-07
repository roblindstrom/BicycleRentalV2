using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Addresses.Commands.DeleteAddress
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
    {
        private readonly IAsyncRepository<Address> _addressRepository;
       
        public DeleteAddressCommandHandler(IAsyncRepository<Address> addressRepository)
        {
            
            _addressRepository = addressRepository;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToDelete = await _addressRepository.GetByIdAsync(request.AddressID);

            await _addressRepository.DeleteAsync(addressToDelete);

            return Unit.Value;
        }
    }
}
