//using System.Collections.Generic;
//using Shop.Core.Entities;
//using Shop.Web.DataAccessLayer;
//
//namespace Shop.Core.EntityInitializers
//{
//    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
//    {
//        protected override void Seed(ShopContext context)
//        {
//            var products = new List<Product>
//            {
//                new Product {Name = "products1"},
//                new Product {Name = "product2"}
//            };
//            products.ForEach(x => context.Products.Add(x));
//            context.SaveChanges();
//
//            var categories = new List<Category>
//            {
//                new Category() {Name = "category1"},
//                new Category() {Name = "category2"}
//            };
//
//            categories.ForEach(x => context.Categories.Add(x));
//            context.SaveChanges();
//        }
//    }
//}