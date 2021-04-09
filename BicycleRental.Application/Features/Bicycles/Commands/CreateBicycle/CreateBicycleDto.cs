using BicycleRental.Domain.Entities;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleDto
    {
        public double BicycleID { get; set; }

        public double PricePerDay { get; set; }


         public BicycleBrand BicycleBrand { get; set; }

         public BicycleSize BicycleSize { get; set; }


        
    }
}