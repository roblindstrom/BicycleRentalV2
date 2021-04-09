using BicycleRental.Domain.Entities;
using BicycleRental.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRental.Api.IntegrationTests.Base
{
    public class Utilities
    {
        public static void InitializeDbForTests(BicycleRentalDbContext context)
        {
           
            context.Bicycles.Add(new Bicycle
            {
                BicycleId = 17497,
                PricePerDay = 100
            });
            context.Bicycles.Add(new Bicycle
            {
                BicycleId = 75352,
                PricePerDay = 125
 
            });
            context.Bicycles.Add(new Bicycle
            {
                BicycleId = 95735,
                PricePerDay = 75
 
            });
            context.Bicycles.Add(new Bicycle
            {
                BicycleId = 15275,
                PricePerDay = 50
            });

            context.SaveChanges();
        }
    }
}