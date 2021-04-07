using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRentalDomain.Entities
{
    public class Address
    {
        public double AddressID { get; set; }

        public string AddressName { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
