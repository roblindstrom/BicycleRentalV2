
using MediatR;

namespace BicycleRental.Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateAddressCommand : IRequest<CreateAddressCommandResponse>
    {
        public double AddressID { get; set; }

        public string AddressName { get; set; }
    }
}
