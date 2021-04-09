using BicycleRental.Domain.Entities;
using MediatR;

namespace BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle
{
    public class UpdateBicycleCommand : IRequest
    {
        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }


         public BicycleBrand BicycleBrand { get; set; }

         public BicycleSize BicycleSize { get; set; }

        //No repsons set, write here if respons needed

    }
}
