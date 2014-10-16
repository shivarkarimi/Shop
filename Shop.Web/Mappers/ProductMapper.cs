using Shop.Core.Entities;
using Shop.Web.ViewModels.Product;

namespace Shop.Web.Mappers
{
    public class ProductMapper
    {
        private ProductViewModel _productViewModel;

        public ProductViewModel ToViewModel(Product product)
        {
            _productViewModel = new ProductViewModel
            {
                ProductName = product.ProductName,
                UnitPrice = string.Format("${0}", product.UnitPrice.ToString("#.##")),
                UnitsInStock = product.UnitsInStock.ToString(),
                UnitsOnOrder = product.UnitsOnOrder.ToString()
            };
            return _productViewModel;
        }
    }
}