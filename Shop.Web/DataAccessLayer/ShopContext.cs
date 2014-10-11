using System.Data.Entity;
using System.Linq;
using Shop.Core;
using Shop.Core.Entities;

namespace Shop.Web.DataAccessLayer
{
    public interface IShopContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        Product GetProductById(int productId);
    }

    public class ShopContext : DbContext, IShopContext
    {
        public ShopContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public Product GetProductById(int productId)
        {
            return Products.ToList().FirstOrDefault(p => p.ProductId == productId);
        }
    }
}