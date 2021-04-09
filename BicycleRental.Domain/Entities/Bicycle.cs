using BicycleRental.Domain.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace BicycleRental.Domain.Entities
{
    public class Bicycle : AuditableEntity
    {
        public double BicycleId { get; set; }

        public double PricePerDay { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BicycleBrand BicycleBrand { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public BicycleSize BicycleSize { get; set; }


        public ICollection<Order> Orders { get; set; }
    }


    public enum BicycleBrand
    { 
        INVALID = 0,
        Trek = 1,
        Norco = 2,
        Schwinn = 3,
        Cannondale = 4,
        Giant = 5,
        Specialized = 6,
        Ghost = 7,
        Coop = 8,
        Pivot = 9


    }

    public enum BicycleSize
    {
        INVALID = 0,
        ExtraSmall = 1,
        Small = 2,
        Medium = 3,
        Large = 4,
        ExtraLarge = 5
    }
}


