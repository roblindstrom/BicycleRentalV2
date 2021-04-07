using BicycleRentalDomain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRentalDomain.Entities
{
    public class Customer : AuditableEntity
    {
        public double PersonalID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public double CustomerAdressID { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
