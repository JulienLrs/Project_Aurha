
using Microsoft.AspNetCore.Mvc;
using MediatR;
using AurhaPortfolioBack.Commands.Category;

namespace AurhaPortfolioBack.Controllers
{
    [Route("api/CategoryFeatures")]
    [ApiController]
    public class CategoryFeaturesController : ControllerBase
    {
        // ATTRIBUTES //
        private readonly IMediator _mediator;

        // CONSTRUCTOR //
        public CategoryFeaturesController(IMediator mediator) { _mediator = mediator; }

        // METHODS //


        // DELETE
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteArtwork(int id)
        {
            var result = await _mediator.Send(new DeleteCategoryCommand(id));
            return Ok("Category deleted complete !");
        }
    }
}
