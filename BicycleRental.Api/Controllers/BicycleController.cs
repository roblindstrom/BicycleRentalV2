using BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle;
using BicycleRental.Application.Features.Bicycles.Commands.DeleteBicycle;
using BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle;
using BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicycleRental.Api.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class BicycleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BicycleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet("GetAllBicycles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BicycleListVm>>> GetAllBicycles()
        {
            var dtos = await _mediator.Send(new GetBicyclesListQuery());
            return Ok(dtos);
        }

        //[Authorize]
        //[HttpGet("allwithevents", Name = "GetCategoriesWithEvents")]
        //[ProducesDefaultResponseType]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<List<CategoryEventListVm>>> GetCategoriesWithEvents(bool includeHistory)
        //{
        //    GetCategoriesListWithEventsQuery getCategoriesListWithEventsQuery = new GetCategoriesListWithEventsQuery() { IncludeHistory = includeHistory };

        //    var dtos = await _mediator.Send(getCategoriesListWithEventsQuery);
        //    return Ok(dtos);
        //}

        [HttpPost("CreateBicycle")]
        public async Task<ActionResult<CreateBicycleCommandResponse>> Create([FromBody] CreateBicycleCommand createBicycleCommand)
        {
            var response = await _mediator.Send(createBicycleCommand);
            return Ok(response);
        }

        [HttpPut("UpdateBicycle")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateBicycleCommand updateBicycleCommand)
        {
            await _mediator.Send(updateBicycleCommand);
            return Ok(updateBicycleCommand);
        }

        [HttpDelete("DeleteBicycle")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(double id)
        {
            var deleteBicycleCommand = new DeleteBicycleCommand() {BicycleID  = id };
            await _mediator.Send(deleteBicycleCommand);
            return Ok(deleteBicycleCommand);
        }
    }
}

