using Shop.Core.Entities;
using Shop.Web.ViewModels.Product;

namespace Shop.Web.Mappers
{
    public class AddEditProductMapper
    {
        private EditProductViewModel _productViewModel;

        public object ToViewModel(Product product)
        {
            _productViewModel = new EditProductViewModel
            {
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice.ToString(),
                UnitsInStock = product.UnitsInStock.ToString()
            };
            return _productViewModel;
        }
    }
}