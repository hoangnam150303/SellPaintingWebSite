
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SellPainting.Models;

namespace SellPainting.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public DbSet<TypesOfPainting> TypesOfPaitings { get; set;}
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
