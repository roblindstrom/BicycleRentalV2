using FluentValidation;

namespace BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle
{
    public class UpdateBicycleCommandValidator : AbstractValidator<UpdateBicycleCommand>
    {
        public UpdateBicycleCommandValidator() 
        {

            RuleFor(b => b.BicycleId)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull()
                .NotEqual(0);

            RuleFor(b => b.PricePerDay)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();
        }
    }
}