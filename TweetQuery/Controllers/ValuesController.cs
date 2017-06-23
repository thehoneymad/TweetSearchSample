namespace TweetQuery.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TweetQuery.Lib;
    using TweetQuery.Lib.Model;
    using TweetSearch.CosmosDb.DocumentDb;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private CosmosDBRepository<Tweet> repository;
        private DocumentDbContext context;

        public ValuesController(CosmosDBRepository<Tweet> repository)
        {
            this.repository = repository;
            this.context = new DocumentDbContext();
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string q)
        {
            if (string.IsNullOrEmpty(q))
                return BadRequest();

            var query = this.context.GenerateQuery(q).Trim();
            return Ok(query);
        }
    }
}
