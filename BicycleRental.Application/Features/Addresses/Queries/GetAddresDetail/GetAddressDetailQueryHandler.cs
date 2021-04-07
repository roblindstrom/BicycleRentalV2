using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail
{
    class GetAddressDetailQueryHandler : IRequestHandler<GetAddressDetailQuery, AddressDetailVm>
    {
        private readonly IAsyncRepository<Address> _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressDetailQueryHandler(IMapper mapper, IAsyncRepository<Address> addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<AddressDetailVm> Handle(GetAddressDetailQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetByIdAsync(request.Id);
            var addressDetailVm = _mapper.Map<AddressDetailVm>(address);

            return addressDetailVm;
        }
    }
}
