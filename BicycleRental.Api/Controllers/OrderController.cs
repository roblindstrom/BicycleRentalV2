using BicycleRental.Application.Features.Orders.Commands.CreateOrder;
using BicycleRental.Application.Features.Orders.Commands.DeleteOrder;
using BicycleRental.Application.Features.Orders.Commands.UpdateOrder;
using BicycleRental.Application.Features.Orders.Queries.GetOrderDetail;
using BicycleRental.Application.Features.Orders.Queries.GetOrdersList;
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
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllOrders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<OrdersListVm>>> GetAllOrders()
        {
            var dtos = await _mediator.Send(new GetOrdersListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetOrderById")]
        public async Task<ActionResult<OrderDetailVm>> GetOrderById(double id)
        {
            var getOrderDetailQuery = new GetOrderDetailQuery() {CustomerID = id };
            return Ok(await _mediator.Send(getOrderDetailQuery));
        }

        [HttpPost(Name = "AddOrder")]
        public async Task<ActionResult<CreateOrderCommandResponse>> Create([FromBody] CreateOrderCommand createOrderCommand)
        {
            var response = await _mediator.Send(createOrderCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateOrderCommand updateOrderCommand)
        {
            await _mediator.Send(updateOrderCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(double id)
        {
            var deleteAddressCommand = new DeleteOrderCommand() { BicycleID = id };
            await _mediator.Send(deleteAddressCommand);
            return NoContent();
        }


    }
}
