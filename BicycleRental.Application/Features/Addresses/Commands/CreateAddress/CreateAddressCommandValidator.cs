using FluentValidation;

namespace BicycleRental.Application.Features.Addresses.Commands.CreateAddress
{
    internal class CreateAddressCommandValidator : AbstractValidator<CreateAddressCommand>
    {
        public CreateAddressCommandValidator()
        {

            RuleFor(c => c.AddressName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }

}