using System.Collections.Generic;
using System.Linq;
using Shop.Core.Entities;
using Shop.Web.DataAccessLayer;

namespace Shop.Web.Models
{
    public class ProductsModel
    {
        private readonly IShopContext  _shopContext;

        public ProductsModel(IShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<Product> Products()
        {        
            return _shopContext.Products.OrderBy(x => x.ProductName).ToList();
        } 
    }
}