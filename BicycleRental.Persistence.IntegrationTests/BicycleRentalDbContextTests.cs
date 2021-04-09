using BicycleRental.Domain.Contracts.Testing;
using BicycleRental.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace BicycleRental.Persistence.IntegrationTests
{
    public class BicycleRentalDbContextTests
    {
        private readonly BicycleRentalDbContext _BicycleRentalDbContext;

        public BicycleRentalDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<BicycleRentalDbContext>().UseInMemoryDatabase(databaseName: "BicycleRentalDbContext").Options;

            _BicycleRentalDbContext = new BicycleRentalDbContext(dbContextOptions);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var bicycle = new Bicycle() { BicycleId = 100, PricePerDay = 1000 };

            _BicycleRentalDbContext.Bicycles.Add(bicycle);
            await _BicycleRentalDbContext.SaveChangesAsync();

            bicycle.BicycleId.ShouldBe(100);
        }
    }
}
