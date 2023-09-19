using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreDB;
using BikeStoreDB.DbOperations;


namespace BikeStore.Controllers
{
    public class HomeController : Controller
    {
        ProductRepository repository = null;
        public HomeController()
        {
            repository = new ProductRepository();
        }

        public ActionResult Home(string search)
        {
           
            if (search != null)
            {
               
                var r = repository.SearchForProduct(search);                
                return View(r);
            }
            
            var result = repository.GetAllProducts();
            return View(result);
        }
       
        public ActionResult View(int id)
        {
            var result = repository.GetProductDetails(id);

            return View(result);                      
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}