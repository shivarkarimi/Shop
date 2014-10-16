using System.Web.Mvc;
using Shop.Web.DataAccessLayer;
using Shop.Web.Mappers;

namespace Shop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IShopContext _shopContext;

        public ProductController(IShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public ActionResult Index(int productId)
        {
            var product = _shopContext.GetProductById(productId);
            var productMapper = new ProductMapper();
            var productViewModel = productMapper.ToViewModel(product);
            return View(productViewModel);
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        public ActionResult Edit (int productId)
        {
            var product = _shopContext.GetProductById(productId);
            
            var productMapper = new EditProductMapper();
            var editProductViewModel = productMapper.ToViewModel(product);

            return View(editProductViewModel);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        public ActionResult Edit(int productID, FormCollection form)
        {
            //Save the item and redirect…
            return View();
        }
    }
}
