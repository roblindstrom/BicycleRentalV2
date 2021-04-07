using BicycleRental.Application.Responses;

namespace BicycleRental.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandResponse : BaseResponse
    {
        public CreateOrderCommandResponse() : base()
        {

        }

        public CreateOrderDto OrderDto { get; set; }
    }
}
