using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class AchievementOperation
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }

        public int AchievementId { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
