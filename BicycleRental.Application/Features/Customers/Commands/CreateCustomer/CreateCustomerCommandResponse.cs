using BicycleRental.Application.Responses;

namespace BicycleRental.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandResponse : BaseResponse
    {
        public CreateCustomerCommandResponse() : base()
        {

        }

        public CreateCustomerDto CustomerDto { get; set; }
    }
}
