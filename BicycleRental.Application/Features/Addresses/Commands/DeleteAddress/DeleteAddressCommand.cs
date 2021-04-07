using MediatR;

namespace BicycleRental.Application.Features.Addresses.Commands.DeleteAddress
{
    public class DeleteAddressCommand : IRequest
    {
        public double AddressID { get; set; }
    }
}
