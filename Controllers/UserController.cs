using Microsoft.AspNetCore.Mvc;

namespace BackendFlashCardsApp.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpPost()]
        public IActionResult CreateUser(RequestDelegate request)
        {
            var user = new User(
                Guid.NewGuid(),
                request.Name,
                request.userName,
                request.Email,
                request.Password,
                DateTime.UtcNow
            );

            return Ok(request);
        }

        [HttpGet()]
        public IActionResult GetUser()
        {
            return Ok();
        }
    }
}