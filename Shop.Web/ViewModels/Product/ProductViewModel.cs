namespace Shop.Web.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
    }
}