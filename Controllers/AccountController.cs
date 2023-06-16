using Microsoft.AspNetCore.Mvc;
using WebApiProject.Model;
using WebApiProject.Repository;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly IAuthManager _authManager;
        //constructor
        public AccountController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register([FromBody] APIUserDTO apiUserDto)
        {
            var errors = await _authManager.RegisterUser(apiUserDto);
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest();
            }
            return Ok();

        }
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LogInDTO logindto)
        {
            var authResponse = await _authManager.Login(logindto);
            if (authResponse == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(authResponse);
            }
        }
    }
}
