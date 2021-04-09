using BicycleRental.Domain.Common;
using System.Collections.Generic;

namespace BicycleRental.Domain.Entities
{
    public class Customer : AuditableEntity
    {


        public double CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public double CustomerAdressID { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }


    }
}
