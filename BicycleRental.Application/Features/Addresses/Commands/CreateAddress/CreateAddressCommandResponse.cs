using BicycleRental.Application.Responses;

namespace BicycleRental.Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateAddressCommandResponse : BaseResponse
    {
        public CreateAddressCommandResponse() : base()
        {

        }
        public string AddressName { get; set; }

        public CreateAddressDto AddressDto { get; set; }


    }
}