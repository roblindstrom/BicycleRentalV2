using BicycleRental.Application.Features.Addresses.Commands.CreateAddress;
using BicycleRental.Application.Features.Addresses.Commands.DeleteAddress;
using BicycleRental.Application.Features.Addresses.Commands.UpdateAddress;
using BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail;
using BicycleRental.Application.Features.Addresses.Queries.GetAddressList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicycleRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllAddresses")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<AddressListVm>>> GetAllEvents()
        {
            var dtos = await _mediator.Send(new GetAddressListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetAddressById")]
        public async Task<ActionResult<AddressDetailVm>> GetEventById(double id)
        {
            var getAddressDetailQuery = new GetAddressDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getAddressDetailQuery));
        }

        [HttpPost(Name = "AddAddress")]
        public async Task<ActionResult<CreateAddressCommandResponse>> Create([FromBody] CreateAddressCommand createAddressCommand)
        {
            var response = await _mediator.Send(createAddressCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateAddressCommand updateAddressCommand)
        {
            await _mediator.Send(updateAddressCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(double id)
        {
            var deleteAddressCommand = new DeleteAddressCommand() { AddressID = id };
            await _mediator.Send(deleteAddressCommand);
            return NoContent();
        }


    }
}
