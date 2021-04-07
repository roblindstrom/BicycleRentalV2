using MediatR;

namespace BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail
{
    public class GetAddressDetailQuery : IRequest<AddressDetailVm>
    {
        public double Id { get; set; }
    }
}
