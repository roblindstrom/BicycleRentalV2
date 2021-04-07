using System.Collections.Generic;

namespace BicycleRental.Domain.Entities
{
    public class Address
    {

        public double AddressID { get; set; }

        public string AddressName { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
