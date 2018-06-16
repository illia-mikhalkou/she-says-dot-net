using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Signature.Domain.Entities.SignIn;

namespace backend.ViewModels
{
    public class AchievementInfo
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Comment { get; set; }
        public ProfileDetails FromUser { get; set; }
    }
}
