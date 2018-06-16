using System.Dynamic;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Produces("application/json")]
    [Route("api/mining")]
    public class MiningController : Controller
    {
        private readonly Database _db;

        public MiningController(Database db)
        {
            _db = db;
        }


        [HttpPost("pull-request")]
        public async Task<IActionResult> LogPullRequest()
        {
            dynamic args = new ExpandoObject();
            args.url = "https://gitlab.itechart-group.com";

            _db.MiningOperations.Add(new MiningOperation
            {
                Amount = 5m,
                Origin = args.url
            });

            await _db.SaveChangesAsync();

            return Ok();
        }


        [HttpPost("issue")]
        public async Task<IActionResult> LogIssues()
        {
            dynamic args = new ExpandoObject();
            args.url = "https://gitlab.itechart-group.com";

            _db.MiningOperations.Add(new MiningOperation
            {
                Amount = 5m,
                Origin = args.url
            });

            await _db.SaveChangesAsync();

            return Ok();
        }
    }
}