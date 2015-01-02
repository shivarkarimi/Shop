using System.ComponentModel.DataAnnotations;

namespace Shop.Web.ViewModels.Product
{
    public class EditProductViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required]     
        [Display(Name = "Unit price")]
        public string UnitPrice { get; set; }

        [Display(Name = "Units in stock")]
        public string UnitsInStock { get; set; }
    }
}