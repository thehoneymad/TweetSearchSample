namespace TweetQuery.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TweetQuery.Lib;
    using TweetQuery.Lib.Model;
    using TweetSearch.CosmosDb.DocumentDb;

    [Route("api/[controller]")]
    public class TweetsController : Controller
    {
        private CosmosDBRepository<Tweet> repository;
        private TweetQueryContext context;

        public TweetsController(CosmosDBRepository<Tweet> repository)
        {
            this.repository = repository;
            this.context = new TweetQueryContext();
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string q)
        {
            if (string.IsNullOrEmpty(q))
                return BadRequest();

            var querySql = this.context.GenerateQuery(q).Trim();
            var result = await repository.GetItemsAsync(querySql);
            return Ok(result);
        }
    }
}
