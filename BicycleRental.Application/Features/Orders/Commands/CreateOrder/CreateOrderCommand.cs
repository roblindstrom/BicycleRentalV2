using MediatR;
using System;

namespace BicycleRental.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
        
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }

        public override string ToString()
        {
            return $"BicycleID: {BicycleID}; CustomerID: {CustomerID};";
        }
    }
}
