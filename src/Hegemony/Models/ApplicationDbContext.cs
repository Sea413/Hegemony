using Hegemony.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hegemony.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Hegemony;integrated security = True");
        }

        public DbSet<Nation> Nations { get; set; }
        public DbSet<Hazard> Hazards { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Geography> Geographies { get; set; }
        public DbSet<Economy> Economies { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<CharacterInfo> CharacterInfo { get; set; }
    }
}