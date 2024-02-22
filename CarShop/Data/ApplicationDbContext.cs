using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CarShop.Models.Car> Car { get; set; }
        public DbSet<CarShop.Models.Part> Part { get; set; }
        public DbSet<CarShop.Models.Blog> Blog { get; set; }
    }
}
