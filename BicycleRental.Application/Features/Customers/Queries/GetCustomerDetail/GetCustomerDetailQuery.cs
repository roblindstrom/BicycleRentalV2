
using MediatR;

namespace BicycleRental.Application.Features.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailVm>
    {
        public double CustomerID { get; set; }

        public double CustomerAdressID { get; set; }

    }
}
