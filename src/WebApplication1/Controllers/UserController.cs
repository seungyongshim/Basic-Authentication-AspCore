namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("anyone")]
        public IActionResult Anyone()
        {
            var message = $"Hello form {nameof(Anyone)}";
            return Ok(message);
        }

        [HttpGet("only-authenticated")]
        [Authorize]
        public IActionResult OnlyAuthenticated()
        {
            var message = $"Hello form {nameof(OnlyAuthenticated)}";
            return Ok(message);
        }

        [HttpGet("only-managers")]
        [Authorize(Policy = "OnlyManagers")]
        public IActionResult OnlyManagers()
        {
            var message = $"Hello from {nameof(OnlyManagers)}";
            return new ObjectResult(message);
        }
    }
}
