using MediatR;
using System;

namespace BicycleRental.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }
    }
}
