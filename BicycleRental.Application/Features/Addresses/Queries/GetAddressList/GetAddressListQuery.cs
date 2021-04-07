using MediatR;
using System.Collections.Generic;

namespace BicycleRental.Application.Features.Addresses.Queries.GetAddressList
{
    public class GetAddressListQuery : IRequest<List<AddressListVm>>
    {
    }
}
