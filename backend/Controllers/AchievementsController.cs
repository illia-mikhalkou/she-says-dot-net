using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Achievements.ToListAsync());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
