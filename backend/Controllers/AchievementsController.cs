using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class AchievementsController : Controller
    {
        private readonly Database _db;

        public AchievementsController(Database db)
        {
            _db = db;
        }

        [ProducesResponseType(200, Type = typeof(List<Achievement>))]
        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Achievements.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GrandAchievement data)
        {
            _db.AchievementOperations.Add(new AchievementOperation
            {
                AchievementId = data.AchievementId,
                Comment = data.Comment,
                FromUserId = data.FromUserId,
                ToUserId = data.ToUserId
            });

            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
