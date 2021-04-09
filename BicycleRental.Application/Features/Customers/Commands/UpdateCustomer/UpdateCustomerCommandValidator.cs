using FluentValidation;

namespace BicycleRental.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(c => c.CustomerID)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();

            RuleFor(c => c.Firstname)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();

            RuleFor(c => c.Lastname)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}