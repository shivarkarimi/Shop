using System.Collections.Generic;
using System.Data.Entity;
using Shop.Core;
using Shop.Core.Entities;

namespace Shop.Web.DataAccessLayer
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>
            {
                new Product {ProductName = "products1"},
                new Product {ProductName = "product2"}
            };
            products.ForEach(x => context.Products.Add(x));
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category() {Name = "category1"},
                new Category() {Name = "category2"}
            };

            categories.ForEach(x => context.Categories.Add(x));
            context.SaveChanges();
        }
    }
}