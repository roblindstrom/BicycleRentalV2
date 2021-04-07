using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrderDetail
{
    public class CustomerDto
    {
        public double CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
