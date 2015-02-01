using System.ComponentModel.DataAnnotations;
using Shop.Core.Entities;

namespace Shop.Web.ViewModels
{

    public class ProductViewModel
    {

        public ProductViewModel(Product product)
        {
            Name = product.ProductName;
            UnitsOnOrder = product.UnitsInStock.ToString();
            UnitPrice = product.UnitPrice.ToString();
            UnitsInStock = product.UnitsInStock.ToString();
        }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; private set; }

        [Required]
        [Display(Name = "Unit price")]
        public string UnitPrice { get; private set; }

        [Display(Name = "Units in stock")]
        public string UnitsInStock { get; private set; }

        public string UnitsOnOrder { get; private set; }
    }
}