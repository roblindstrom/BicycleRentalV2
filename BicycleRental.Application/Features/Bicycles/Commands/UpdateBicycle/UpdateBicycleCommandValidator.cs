using FluentValidation;

namespace BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle
{
    internal class UpdateBicycleCommandValidator : AbstractValidator<UpdateBicycleCommand>
    {
        public UpdateBicycleCommandValidator() 
        {
        }
    }
}