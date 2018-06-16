using System.Threading.Tasks;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Signature.Domain.Services;

namespace backend.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly SmgService _smg;

        public UsersController(SmgService smg)
        {
            _smg = smg;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]Login data)
        {
            return Ok(await _smg.Authenticate(data.UserName, data.Password));
        }

        [HttpGet("")]
        public async Task<IActionResult> GetList(int session)
        {
            var response = await _smg.GetAllEmployees(session);
            if (!string.IsNullOrEmpty(response.ErrorCode))
            {
                return Unauthorized();
            }


            return Ok(response.Profiles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int session, int id)
        {
            var response = await _smg.GetEmployeeDetailsById(session, id);
            if (!string.IsNullOrEmpty(response.ErrorCode))
            {
                return Unauthorized();
            }

            return Ok(response.Profile);
        }
    }
}