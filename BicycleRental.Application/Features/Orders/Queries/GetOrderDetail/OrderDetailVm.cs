using BicycleRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrderDetail
{
    public class OrderDetailVm
    {
       
        public double BicycleID { get; set; }

        public double CustomerID { get; set; }

        public DateTime BookingStartDate { get; set; }

        public DateTime BookingEndDate { get; set; }

        public Bicycle Bicycle { get; set; }

        public Customer Customer { get; set; }

        public BicycleDto BicycleDto { get; set; }

        public CustomerDto CustomerDto { get; set;}
    }
}

