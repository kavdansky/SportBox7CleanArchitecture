namespace SportBox7.Web.Features
{
    using System.Threading.Tasks;
    using Application.Contracts;
    using Application.Features.Identity;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SportBox7.Application.Features.Identity.LoginUser;
    using SportBox7.Web.Common;

    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ApiController
    {
        private readonly IIdentity identity;

        public IdentityController(IIdentity identity) => this.identity = identity;

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(UserInputModel model)
        {
            var result = await this.identity.Register(model);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok();
        }

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginOutputModel>> Login(LoginUserCommand command)
            => await this.Mediator.Send(command).ToActionResult();
       
    }
}
