using System.Web.Mvc;
using Shop.Web.DataAccessLayer;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IShopContext _shopContext;

        public ProductsController(IShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public ActionResult Index()
        {
            var productsModel = new ProductsModel(_shopContext);
            return View(productsModel);
        }
    }
}
