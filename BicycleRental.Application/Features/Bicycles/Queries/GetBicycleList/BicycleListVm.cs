using BicycleRental.Domain.Entities;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList
{
    public class BicycleListVm
    {
        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }


        public BicycleBrand BicycleBrand { get; set; }

        public BicycleSize BicycleSize { get; set; }


    }
}