namespace TweetQuery.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string q)
        {
            if (string.IsNullOrEmpty(q))
                return BadRequest();

            return Ok();
        }
    }
}
