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
    [Authorize(Roles ="admin")]
    public class CategoryController : Controller
    {
        CategoryRepository repository = null;


        public CategoryController()
        {
            repository = new CategoryRepository();
        }

        // GET: Category
        public ActionResult Create()
        {         
            return View();
        }

        [HttpPost]
        public ActionResult Create(categoryModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.CreateCategory(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data added";
                }
            }
            return View();
        }

        public ActionResult AllCategory() {

            var allCategories = repository.GetAllCategories();
            return View(allCategories);
        }

        public ActionResult UpdateDetails()
        {
            return View();
        }
    }
}