using BicycleRental.Application.Features.Customers.Commands.CreateCustomer;
using BicycleRental.Application.Features.Customers.Commands.DeleteCustomer;
using BicycleRental.Application.Features.Customers.Commands.UpdateCustomer;
using BicycleRental.Application.Features.Customers.Queries.GetCustomerDetail;
using BicycleRental.Application.Features.Customers.Queries.GetCustomersList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllCustomers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<CustomerListVm>>> GetAllCustomers()
        {
            var dtos = await _mediator.Send(new GetCustomersListQuery());
            return Ok(dtos);
        }

        [HttpGet("GetCustomerById")]
        public async Task<ActionResult<CustomerDetailVm>> GetCustomerById(double customerID)
        {
            var getCustomerDetailQuery = new GetCustomerDetailQuery() { CustomerID = customerID};
            return Ok(await _mediator.Send(getCustomerDetailQuery));
        }

        [HttpPost(Name = "AddCustomer")]
        public async Task<ActionResult<CreateCustomerCommandResponse>> Create([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            var response = await _mediator.Send(createCustomerCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateCustomer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateCustomerCommand updateCustomerCommand)
        {
            await _mediator.Send(updateCustomerCommand);
            return Ok();
        }

        [HttpDelete("{id}", Name = "DeleteCustomer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(double id)
        {
            var deleteCustomerCommand = new DeleteCustomerCommand() { CustomerID = id };
            await _mediator.Send(deleteCustomerCommand);
            return Ok();
        }


    }
}
