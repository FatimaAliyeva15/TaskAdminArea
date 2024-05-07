using AdminArea_Pronia.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminArea_Pronia.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Tag> Tags {  get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductPhoto> ProductsPhoto { get; set; }
    }
}
