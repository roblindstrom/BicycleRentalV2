using FluentValidation;

namespace BicycleRental.Application.Features.Orders.Commands.UpdateOrder
{
    internal class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
        }
    }
}