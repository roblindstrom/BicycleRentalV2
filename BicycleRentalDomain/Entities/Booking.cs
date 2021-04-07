using BicycleRentalDomain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRentalDomain.Entities
{
    public class Booking : AuditableEntity
    {



        public double BookedBicycle { get; set; }

        public double CustomerWithBooking { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }

        public Bicycle Bicycle { get; set; }

        public Customer Customer { get; set; }




    }
}
