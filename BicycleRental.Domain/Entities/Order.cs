using BicycleRental.Domain.Common;
using System;

namespace BicycleRental.Domain.Entities
{
    public class Order : AuditableEntity
    {
        
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }

        public Bicycle Bicycle { get; set; }

        public Customer Customer { get; set; }
    }
}
