using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Web.DataAccessLayer;
using Shop.Web.Mappers;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IShopContext _shopContext;

        public TestController(IShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        // GET: Test
        public ActionResult Index()
        {
            var productsModel = new ProductsModel(_shopContext);
            return View(productsModel);
        }
    }
}