using System.Data.Entity.Infrastructure;
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

        public ActionResult Index(int id)
        {
            var product = _shopContext.GetProductById(id);
            var productMapper = new ProductMapper();
            var productViewModel = productMapper.ToViewModel(product);
            return View(productViewModel);
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        public ActionResult Edit(int id)
        {
            var product = _shopContext.GetProductById(id);

            var productMapper = new EditProductMapper();
            var editProductViewModel = productMapper.ToViewModel(product);

            return View(editProductViewModel);
        }

        [HttpPost]
        [AcceptVerbs("POST")]
        public ActionResult Edit(int id, FormCollection form)
        {
            var product = _shopContext.GetProductById(id);

            try
            {
                if (ModelState.IsValid)
                {
                    UpdateModel(product);
                    _shopContext.Save(product);
                    return RedirectToAction("Edit", id);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists, see your system administrator.");                
            }
            return View("Edit");
        }
    }
}
