using BicycleRental.Application.Responses;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleCommandResponse : BaseResponse
    {
        public CreateBicycleCommandResponse() : base()
        {

        }

        public CreateBicycleDto BicycleDto { get; set; }
    }
}
