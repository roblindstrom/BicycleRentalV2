using FluentValidation;

namespace BicycleRental.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(o => o.BicycleID)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(o => o.CustomerID)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(o => o.BookingStartDate)
                .LessThanOrEqualTo(o => o.BookingEndDate)
                .NotNull();
        }
    }
}