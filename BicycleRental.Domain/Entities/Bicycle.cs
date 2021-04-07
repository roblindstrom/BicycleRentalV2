using System.Collections.Generic;

namespace BicycleRental.Domain.Entities
{
    public class Bicycle
    {
        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }


        // public BicycleBrand BicycleBrand { get; set; }

        // public BicycleSize BicycleSize { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
