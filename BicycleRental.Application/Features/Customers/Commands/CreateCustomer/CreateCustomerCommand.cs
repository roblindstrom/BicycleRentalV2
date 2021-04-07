using MediatR;

namespace BicycleRental.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<CreateCustomerCommandResponse>
    {
        public double CustomerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public double CustomerAdressID { get; set; }

        public override string ToString()
        {
            return $"CustomerID: {CustomerID}; Firstname: {Firstname}; Lastname: {Lastname}; ";
        }
    }
}
