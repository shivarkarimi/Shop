using System.Data.Entity.Infrastructure;
using System.Web.Mvc;
using Shop.Core.Entities;
using Shop.Web.DataAccessLayer;
using Shop.Web.Mappers;

namespace Shop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IShopContext _shopContext;
        private readonly ProductMapper _productMapper;

        public ProductController(IShopContext shopContext, ProductMapper productMapper)
        {
            _shopContext = shopContext;
            _productMapper = productMapper;
        }

        public ActionResult Index(int id)
        {
            var product = _shopContext.GetProductById(id);
            var productViewModel = _productMapper.ToViewModel(product);
            return View(productViewModel);
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        public ActionResult Edit(int id)
        {
            var product = _shopContext.GetProductById(id);

            var productMapper = new AddEditProductMapper();
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


        [HttpGet]
        [AcceptVerbs("GET")]
        public ActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        [AcceptVerbs("Post")]
        public ActionResult Create([Bind(Exclude = "ProductId")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _shopContext.Add(product);
                    var productViewModel = _productMapper.ToViewModel(product);
                    return View("Index", productViewModel);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("",
                    "Unable to Add the item. Try again, and if the problem persists, see your system administrator.");
            }

            return View("Create");
        }
    }
}
