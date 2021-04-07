using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Addresses.Queries.GetAddressList
{
    public class GetAddressListQueryHandler : IRequestHandler<GetAddressListQuery, List<AddressListVm>>
    {
        private readonly IAsyncRepository<Address> _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressListQueryHandler(IMapper mapper, IAsyncRepository<Address> addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressListVm>> Handle(GetAddressListQuery request, CancellationToken cancellationToken)
        {
            var allAddress = (await _addressRepository.ListAllAsync()).OrderBy(x => x.AddressID);
            return _mapper.Map<List<AddressListVm>>(allAddress);
        }




    }
}
