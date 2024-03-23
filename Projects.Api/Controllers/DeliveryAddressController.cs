using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.DeliveryAddressFeatures.Commands;
using Project.Application.Features.DeliveryAddressFeatures.Queries;

namespace Projects.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryAddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeliveryAddressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateDeliveryAddressCommand commend)
        {
            return Ok(await _mediator.Send(commend));
        }
        [HttpGet("getAllDeliveryAddress")]
        public async Task<IActionResult> getAllCustomer()
        {
            return Ok(await _mediator.Send(new GetAllDeliveryAddressQuery()));
        }
        [HttpGet("getDeliveryAddress/{id}")]
        public async Task<IActionResult> getCustomer(Guid id)
        {
            return Ok(await _mediator.Send(new GetDeliveryAddressByIdQuery(id)));
        }
        [HttpDelete("DeleteDeliveryAddress/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteDeliveryAddressCommand(id)));
        }
        [HttpPut("UpdateDeliveryAddress/{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateDeliveryAddressCommand commend)
        {
            if (id != commend.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(commend));
        }
    }
}
