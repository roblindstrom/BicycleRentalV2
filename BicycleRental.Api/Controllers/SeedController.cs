using BicycleRental.Application.Features.Seeds.Commands.CreateSeeds;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BicycleRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {

        private readonly IMediator _mediator;

        public SeedController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Seed-Data")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesDefaultResponseType]
        public async Task<ActionResult<CreateSeedCommandResponse>>CreateAllSeeds(CreateSeedCommand createSeedsCommand)
        {
            var response = await _mediator.Send(createSeedsCommand);
            return Ok(response);
        }
    }
}
