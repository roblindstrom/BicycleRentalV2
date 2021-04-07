using MediatR;

namespace BicycleRental.Application.Features.Addresses.Commands.UpdateAddress
{
    public class UpdateAddressCommand : IRequest
    {
        public double AddressID { get; set; }
        public string AddressName { get; set; }
    }
}
