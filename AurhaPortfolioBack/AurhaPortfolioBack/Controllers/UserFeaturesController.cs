using AurhaPortfolioBack.Commands;
using AurhaPortfolioBack.Commands.User;
using AurhaPortfolioBack.Migrations;
using AurhaPortfolioBack.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AurhaPortfolioBack.Controllers
{
    [Route("api/UserFeatures")]
    [ApiController]

    public class UserFeaturesController : ControllerBase
    {
        // ATTRIBUTES //
        private readonly IMediator _mediator;

        // CONSTRUCTOR //
        public UserFeaturesController(IMediator mediator) { _mediator = mediator; }

        // METHODS //

        // GET
        [HttpGet("{id:int}", Name = "GetUserById")]
        public async Task<ActionResult> GetUsers(int id)
        {
            var user = await _mediator.Send(new GetUserByIdQuery(id));
            return Ok(user);
        }

        // CREATE
        [HttpPost("Create")]
        public async Task<ActionResult> UserFeatures([FromBody] AddUserCommand user)
        {
            var productToReturn = await _mediator.Send(user);
            return Ok("User Created Sucessfuly !");
        }

        // UPDATE
        [HttpPost("Update")]
        public async Task<ActionResult> UserFeatures([FromBody] UpdateUserCommand user)
        {
            var productToReturn = await _mediator.Send(user);
            return Ok("Update Succeed");

        }

        // DELETE
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult> DeleteUsers(int id)
        {
            var result = await _mediator.Send(new DeleteUserCommand(id));
            return Ok("User deleted complete !");
        }
    }
}
