using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRentalDomain.Entities
{
    public class CustomerAddress
    {
        public double CustomerAddressID { get; set; }

        public double AddressID { get; set; }

        public Address Address { get; set; }

        public Customer Customer { get; set; }
    }
}
