using BicycleRental.Domain.Entities;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleDetail
{
    public class BicycleDetailVm
    {
        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }


         public BicycleBrand BicycleBrand { get; set; }

         public BicycleSize BicycleSize { get; set; }

        public OrderDto OrderDto { get; set; }
    }
}