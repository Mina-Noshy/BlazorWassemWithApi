using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebModels.Seeding;
using MyWebModels.Models;
using MyWebModels.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebModels.ViewModels;

namespace MyWebModels.Database
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            RoleSeed.Seed(builder);
            UserSeed.Seed(builder);
            UserRoleSeed.Seed(builder);
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }

    }
}
