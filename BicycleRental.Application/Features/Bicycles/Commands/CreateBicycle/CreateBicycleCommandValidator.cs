using FluentValidation;
using System.Collections.Generic;
using System.Linq;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleCommandValidator : AbstractValidator<CreateBicycleCommand>
    {
       
        public CreateBicycleCommandValidator()
        {
            RuleFor(b => b.BicycleID)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull()
                .NotEqual(0);
                
            

            RuleFor(b => b.PricePerDay)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();

            


        }
        


    }
}
