using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Witcher.Beastiary.Core.Models;

namespace Witcher.Beastiary.Data.Context
{
    public class MonsterDbContext : DbContext
    {
        public MonsterDbContext(DbContextOptions<MonsterDbContext> options)
            :base(options)
        {
                
        }

        public DbSet<MonsterModel> Beastiary { get; set; }
    }
}
