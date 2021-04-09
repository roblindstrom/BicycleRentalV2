using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Application.Features.Addresses.Commands.UpdateAddress
{
    public class UpdateAddressCommandValidator : AbstractValidator<UpdateAddressCommand>
    {
        public UpdateAddressCommandValidator()
        {
            RuleFor(c => c.AddressName)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();
        }
    }
}
