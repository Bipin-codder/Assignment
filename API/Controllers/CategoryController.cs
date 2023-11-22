using Application.DTOs.Attribute;
using Application.DTOs.Category;
using Application.Features.Attributes.Requests.Commands;
using Application.Features.Attributes.Requests.Queries;
using Application.Features.Category.Requests.Commands;
using Application.Features.Category.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMediator _mediator;      

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: CategoryController
        [HttpGet]
        public async Task<ActionResult<List<CategoryDtos>>> Get()
        {
            var attribute = await _mediator.Send(new GetCategoryRequest());
            return Ok(attribute);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDtos category)
        {
            var command = new CreateCategoryCommand { CategoryDtos = category };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CategoryDtos category)
        {
            var command = new UpdateCategoryCommand { CategoryDtos = category };
            var response = await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
