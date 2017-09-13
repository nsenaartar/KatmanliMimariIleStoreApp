using StoreApp.Business.Abstract;
using StoreApp.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductManager _productManager;    

        public HomeController()
        {
            //dependency injection
            _productManager = new ProductManager();       
        }

        // GET: Home
        public ActionResult Index()
        {
            var products = _productManager.GetAll()
                .Where(i => i.isApproved == true && i.isHome == true)
                .ToList();

            return View(products);
        }
    }
}