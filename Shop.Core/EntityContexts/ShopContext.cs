using System.Data.Entity;
using Shop.Core;
using Shop.Core.Entities;

namespace Shop.Web.DataAccessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}