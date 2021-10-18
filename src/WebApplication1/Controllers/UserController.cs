namespace WebApplication1.Controllers
{
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
        public IActionResult OnlyAuthenticated()
        {
            var message = $"Hello form {nameof(OnlyAuthenticated)}";
            return Ok(message);
        }
    }
}