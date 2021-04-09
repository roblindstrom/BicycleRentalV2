using BicycleRental.Api.IntegrationTests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BicycleRental.Api.IntegrationTests.HealthCheck
{

    //kollar att Api:n kan starta och att basic funktioner fungerar som de ska.
    public class HealthCheckTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        public HealthCheckTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.GetAnonymousClient();

        }

        [Fact]
        public async Task HealthCheckReturnsOK()
        {
            var response = await _client.GetAsync("/healthcheck");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
