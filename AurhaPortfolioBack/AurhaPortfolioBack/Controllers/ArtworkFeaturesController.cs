using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MediatR;
using AurhaPortfolioBack.Queries;
using AurhaPortfolioBack.Commands.Artwork;
using Microsoft.AspNetCore.Mvc;


namespace AurhaPortfolioBack.Controllers
{
    [Route("api/ArtworkFeatures")]
    [ApiController]

    public class ArtworkFeaturesController : ControllerBase
    {
        // ATTRIBUTES //
        private readonly IMediator _mediator;

        // CONSTRUCTOR //
        public ArtworkFeaturesController(IMediator mediator) { _mediator = mediator; }

        // METHODS //

        // GET
        [HttpGet("{id:int}", Name = "GetArtworkById")]
        public async Task<ActionResult> GetArtwork(int id)
        {
            var artwork = await _mediator.Send(new GetArtworkByIdQuery(id));
            return Ok(artwork);
        }


        // CREATE
        [HttpPost("Create")]
        public async Task<ActionResult> ArtworkFeatures([FromBody] AddArtworkCommand artwork)
        {
            var artworkToReturn = await _mediator.Send(artwork);
            return Ok("Artwork created succesfuly");
        }

        // UPDATE
        [HttpPost("Update")]
        public async Task<ActionResult> ArtworkFeatures([FromBody] UpdateArtworkCommand artwork)
        {
            var artworkToReturn = await _mediator.Send(artwork);
            return Ok("Update Succeed");
        }

        // DELETE
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteArtwork(int id)
        {
            var result = await _mediator.Send(new DeleteArtworkCommand(id));
            return Ok("User deleted complete !");
        }

        
    }
}
