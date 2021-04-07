using FluentValidation;

namespace BicycleRental.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {

        public CreateCustomerCommandValidator()
        {
            RuleFor(c => c.CustomerID)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}
