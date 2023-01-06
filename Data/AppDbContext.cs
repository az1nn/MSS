using Microsoft.EntityFrameworkCore;
using MSS.Models.Domain;

namespace MSS.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<Product> Product { get; set;}
    }
}