using MediatR;

namespace BicycleRental.Application.Features.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest
    {
        public double CustomerID { get; set; }
    }
}
