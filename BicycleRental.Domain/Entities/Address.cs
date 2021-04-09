using BicycleRental.Domain.Common;
using System.Collections.Generic;

namespace BicycleRental.Domain.Entities
{
    public class Address : AuditableEntity
    {

        public double AddressID { get; set; }

        public string AddressName { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
