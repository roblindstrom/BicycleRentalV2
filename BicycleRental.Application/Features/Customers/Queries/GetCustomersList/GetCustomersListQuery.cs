using MediatR;
using System.Collections.Generic;

namespace BicycleRental.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQuery : IRequest<List<CustomerListVm>>
    {
    }
}
