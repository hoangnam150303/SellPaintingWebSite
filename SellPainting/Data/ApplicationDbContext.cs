using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SellPainting.Models;

namespace SellPainting.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
       public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
