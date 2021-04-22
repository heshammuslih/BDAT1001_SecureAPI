using Server.Services;
using Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost]
        public IActionResult AuthenticateUser([FromBody] User model)
        {
            AuthenticateService authenticateService = new AuthenticateService();
            var user = authenticateService.Authenticate(model.username, model.password);
            if (user == null)
            {
                return BadRequest(new { Message = "invalid username or password" });
            }
            else
                return Ok(user);
        }
    }
}
