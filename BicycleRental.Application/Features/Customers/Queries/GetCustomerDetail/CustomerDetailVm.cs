using BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail;
using System.Collections.Generic;

namespace BicycleRental.Application.Features.Customers.Queries.GetCustomerDetail
{
    public class CustomerDetailVm
    {
        public double CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public double CustomerAdressID { get; set; }

        public AddressDetailVm AddressVm { get; set; }
    }
}
