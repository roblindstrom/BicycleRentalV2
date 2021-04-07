namespace BicycleRental.Domain.Entities
{
    public class CustomerAddress
    {
        public double CustomerAddressID { get; set; }

        public double AddressID { get; set; }

        public Address Address { get; set; }

        public Customer Customer { get; set; }
    }
}
