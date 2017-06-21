namespace TweetQuery.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Search(string q)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
