using FluentValidation;

namespace BicycleRental.Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateAddressCommandValidator : AbstractValidator<CreateAddressCommand>
    {
        public CreateAddressCommandValidator()
        {

            RuleFor(c => c.AddressName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();

                RuleFor(c => c.AddressID)
                .NotEqual(0);


        }
    }

}