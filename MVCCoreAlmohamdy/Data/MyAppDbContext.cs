using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCCoreAlmohamdy.Models;

namespace MVCCoreAlmohamdy.Data
{
    public class MyAppDbContext : IdentityDbContext<IdentityUser>
    {

        public MyAppDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<MyAppDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Computers" },
                new Category() { Id = 2, Name = "Mobiles" },
                new Category() { Id = 3, Name = "Electric machines" }
                );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "admin", ConcurrencyStamp = Guid.NewGuid().ToString() },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Manager", NormalizedName = "manager", ConcurrencyStamp = Guid.NewGuid().ToString() },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "user", ConcurrencyStamp = Guid.NewGuid().ToString() }
             );

            base.OnModelCreating(modelBuilder);
        }
    }
}
