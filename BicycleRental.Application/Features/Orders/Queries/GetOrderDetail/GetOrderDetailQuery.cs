using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrderDetail
{
    public class GetOrderDetailQuery : IRequest<OrderDetailVm>
    {
        public double CustomerID { get; set; }

        public double BicycleID { get; set; }
    }
}
