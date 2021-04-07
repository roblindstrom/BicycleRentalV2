using MediatR;
using System.Collections.Generic;

namespace BicycleRental.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersListVm>>
    {
    }
}
