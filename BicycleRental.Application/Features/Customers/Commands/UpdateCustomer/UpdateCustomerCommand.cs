using MediatR;

namespace BicycleRental.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest
    {
        public double CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public double CustomerAdressID { get; set; }
    }
}
