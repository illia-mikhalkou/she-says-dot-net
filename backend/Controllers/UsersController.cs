using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Signature.Domain.Entities.SignIn;
using Signature.Domain.Services;

namespace backend.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly SmgService _smg;
        private readonly Database _db;

        public UsersController(SmgService smg, Database db)
        {
            _smg = smg;
            this._db = db;
        }

        [ProducesResponseType(200, Type = typeof(AuthenticateOutput))]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]Login data)
        {
            return Ok(await _smg.Authenticate(data.UserName, data.Password));
        }

        [ProducesResponseType(200, Type = typeof(List<ShortProfileModel>))]
        [HttpGet]
        public async Task<IActionResult> GetList(int session)
        {
            var response = await _smg.GetAllEmployees(session);
            if (!string.IsNullOrEmpty(response.ErrorCode))
            {
                return Unauthorized();
            }

            foreach (var profile in response.Profiles)
            {
                profile.Achievements = await GetAchievements(session, profile.ProfileId);
            }

            return Ok(response.Profiles);
        }

        [ProducesResponseType(200, Type = typeof(ProfileDetails))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int session, int id)
        {
            var response = await _smg.GetEmployeeDetailsById(session, id);
            if (!string.IsNullOrEmpty(response.ErrorCode))
            {
                return Unauthorized();
            }

            response.Profile.Achievements = await GetAchievements(session, id);

            return Ok(response.Profile);
        }



        private async Task<List<AchievementInfo>> GetAchievements(int session, int userId)
        {
            var list = await _db.AchievementOperations.Where(a => a.ToUserId == userId).Include(a => a.Achievement).ToListAsync();

            var result = new List<AchievementInfo>();
            foreach (var item in list)
            {
                result.Add(new AchievementInfo
                {
                    Comment = item.Comment,
                    Id = item.Id,
                    FromUser = (await _smg.GetEmployeeDetailsById(session, item.FromUserId)).Profile,
                    Icon = item.Achievement.Url
                });
            }

            return result;
        }
    }
}