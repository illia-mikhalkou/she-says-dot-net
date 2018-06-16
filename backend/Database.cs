using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
        }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<AchievementOperation> AchievementOperations { get; set; }
        public DbSet<MiningOperation> MiningOperations { get; set; }
        public DbSet<PurchaseOperation> PurchaseOperations { get; set; }
    }
}
