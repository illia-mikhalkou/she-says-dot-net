using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ViewModels
{
    public class GrandAchievement
    {
        public int AchievementId { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public string Comment { get; set; }
    }
}
