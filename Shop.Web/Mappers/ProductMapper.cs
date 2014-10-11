using Shop.Core.Entities;
using Shop.Web.Controllers;

namespace Shop.Web.Mappers
{
    public class ProductMapper
    {
        private ProductViewModel productViewModel;

        public ProductViewModel ToViewModel(Product product)
        {
            productViewModel = new ProductViewModel
            {
                ProductName = product.ProductName,
                UnitPrice = string.Format("${0}", product.UnitPrice.ToString("#.##")),
                UnitsInStock = product.UnitsInStock.ToString(),
                UnitsOnOrder = product.UnitsOnOrder.ToString()
            };
            return productViewModel;
        }
    }
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
    }
}