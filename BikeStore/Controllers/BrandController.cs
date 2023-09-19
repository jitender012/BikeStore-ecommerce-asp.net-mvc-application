using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreModels;
using BikeStoreDB.DbOperations;

namespace BikeStore.Controllers
{
    public class BrandController : Controller
    {
        BrandRepository repository = null;
        public BrandController()
        {
            repository = new BrandRepository();
        }
        // GET: Brand
        public ActionResult Index()
        {
            var result = repository.GetAllBrands();
            return View(result);
        }
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(brandModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddBrand(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data added.";
                }
            }                        
            return View();
        }

        public ActionResult Delete(brandModel model)
        {
            var br = repository.GetBrandDetails(model.brand_id);
            return View(br);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repository.DeleteBrand(id);
            return RedirectToAction("Index");
        }

    }
}