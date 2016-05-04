using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Hegemony.Models;

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



        public DbSet<Nation> Nation { get; set; }
        public DbSet<Hazard> Hazards { get; set; }
    }
}