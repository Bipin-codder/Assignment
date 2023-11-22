using Application.DTOs.Attribute;
using Application.DTOs.Product;
using Application.Features.Attributes.Requests.Commands;
using Application.Features.Attributes.Requests.Queries;
using Application.Features.Products.Requests.Commands;
using Application.Features.Products.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AttributeController : Controller
    {
        private readonly IMediator _mediator;

        public AttributeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: AttributeController
        [HttpGet]
        public async Task<ActionResult<List<AttributeDto>>> Get()
        {
            var attribute = await _mediator.Send(new GetAttributeDetailRequest());
            return Ok(attribute);
        }

        // GET: AttributeController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttributeDto>> Get(int id)
        {
            var attribute = await _mediator.Send(new GetAttributeDetailRequest { id = id });
            return Ok(attribute);
        }


        // POST api/<AttributeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AttributeDto attribute)
        {
            var command = new CreateAttributeCommand { Attribute = attribute };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // PUT api/<AttributeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AttributeDto attribute)
        {
            var command = new UpdateAttributeCommand { AttributeDto = attribute };
            var response = await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<AttributeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteAttributeCommand { id = id };
            await _mediator.Send(command);
            return NoContent();
        }
        
    }
}
