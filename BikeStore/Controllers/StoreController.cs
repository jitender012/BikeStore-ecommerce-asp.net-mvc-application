using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreDB;
using BikeStoreDB.DbOperations;
using BikeStoreModels;

namespace BikeStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        StoreRepository repository = null;
        public StoreController()
        {
            repository = new StoreRepository();
        }
        public ActionResult Index()
        {
            var result = repository.GetAllStores();
            return View(result);
        }


        public ActionResult Details(int id)
        {
            var result = repository.GetStoreDetails(id);
            return View(result);
        }

        // GET: Product
        public ActionResult Create()
        {               
            return View();
        }

        //POST: Product
        [HttpPost]
        public ActionResult Create(storeModel model)
        {

            BikeStores_2Entities db = new BikeStores_2Entities();
   
            if (ModelState.IsValid)
            {
                int id = repository.AddStore(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data added.";
                }
            }
            return View();
        }


        public ActionResult Edit(int id)
        {
            var st = repository.GetStoreDetails(id);
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(storeModel model)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateStoreDetails(model.store_id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(storeModel model)
        {
            var st = repository.GetStoreDetails(model.store_id);
            return View(st);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repository.DeleteStore(id);
            return RedirectToAction("Index");
        }
    }
}