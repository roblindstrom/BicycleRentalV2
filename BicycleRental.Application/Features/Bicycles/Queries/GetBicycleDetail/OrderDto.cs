using System;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleDetail
{
    public class OrderDto
    {
        
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }
    }
}
