using BicycleRentalDomain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRentalDomain.Entities
{
    public class Bicycle : AuditableEntity
    {

        public Bicycle()
        {
            Bookings = new List<Booking>();
        }


        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }



        //public int BookingID { get; set; }
       // public BicycleBrand BicycleBrand { get; set; }

       // public BicycleSize BicycleSize { get; set; }

        public ICollection<Booking> Bookings { get; set; }


    }
}
