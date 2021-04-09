using BicycleRental.Api.IntegrationTests.Base;
using BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle;
using BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList;
using BicycleRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace BicycleRental.Api.IntegrationTests.Controllers
{
    public class BicycleControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public BicycleControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            factory.ClientOptions.BaseAddress = new Uri("https://localhost:44347/api/bicycle/");
            _client = factory.GetAnonymousClient();
        }
      
        [Fact]
        public async Task GetAllTest()
        {

            var result = await _client.GetFromJsonAsync<List<BicycleListVm>>("all");

            Assert.IsType<List<BicycleListVm>>(result);
            Assert.NotEmpty(result);
            Assert.NotNull(result);
            
        }
        
        

        
    }
}