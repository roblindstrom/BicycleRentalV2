using MediatR;

namespace BicycleRental.Application.Features.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }
    }
}
