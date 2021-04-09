using BicycleRental.Domain.Common;

namespace BicycleRental.Domain.Entities
{
    public class CustomerAddress : AuditableEntity
    {
        public double CustomerAddressID { get; set; }

        public double AddressID { get; set; }

        public Address Address { get; set; }

        public Customer Customer { get; set; }
    }
}
