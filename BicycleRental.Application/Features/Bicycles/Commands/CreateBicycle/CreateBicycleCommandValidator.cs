using FluentValidation;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleCommandValidator : AbstractValidator<CreateBicycleCommand>
    {

        public CreateBicycleCommandValidator()
        {
            RuleFor(b => b.BicycleID)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();



        }



    }
}
