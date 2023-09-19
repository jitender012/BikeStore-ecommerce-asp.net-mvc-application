using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreModels;
using BikeStoreDB.DbOperations;
using BikeStoreDB;

namespace BikeStore.Controllers
{
    [RoutePrefix("product")]
    public class ProductController : Controller
    {
        ProductRepository repository = null;
        public ProductController()
        {
            repository = new ProductRepository();
        }
       
        public ActionResult AllProducts()
        {
            var result = repository.GetAllProducts();
            return View(result);
        }

  
        public ActionResult ProductDetails(int id)
        {
            var result = repository.GetProductDetails(id);
            return View(result);
        }
       
     
        // GET: Product
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            BikeStores_2Entities db = new BikeStores_2Entities();
            List<categoryModel> cat = db.categories.Select(x => new categoryModel
            {
                category_id = x.category_id,
                category_name = x.category_name
            }).ToList();

            List<brandModel> brands = db.brands.Select(x => new brandModel
            {
                brand_id = x.brand_id,
                brand_name = x.brand_name
            }).ToList();

            ViewBag.CategoryList = new SelectList(cat, "category_id", "category_name");
            ViewBag.BrandList = new SelectList(brands, "brand_id", "brand_name");

            return View();
        }

        //POST: Product
        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(productModel model)
        {
            BikeStores_2Entities db = new BikeStores_2Entities();
            List<categoryModel> cat = db.categories.Select(x => new categoryModel
            {
                category_id = x.category_id,
                category_name = x.category_name
            }).ToList();

            List<brandModel> brands = db.brands.Select(x => new brandModel
            {
                brand_id = x.brand_id,
                brand_name = x.brand_name
            }).ToList();

            ViewBag.CategoryList = new SelectList(cat, "category_id", "category_name");
            ViewBag.BrandList = new SelectList(brands, "brand_id", "brand_name");

            if (ModelState.IsValid)
            {
                int id = repository.AddProduct(model);
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
            var prod = repository.GetProductDetails(id);
            return View(prod);
        }
        [HttpPost]
        public ActionResult Edit(productModel model)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateProductDetails(model.product_id, model);
                return RedirectToAction("AllProducts");
            }

            return View();
        }
       
        public ActionResult Delete(productModel model)
        {
            var prod = repository.GetProductDetails(model.product_id);
            return View(prod);
        }
       
        [HttpPost]
        public ActionResult Delete(int id)
        {           
                repository.DeleteProduct(id);
                return RedirectToAction("AllProducts");           
        }

    }
}