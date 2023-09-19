using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStore.Models;
using Newtonsoft.Json;

namespace BikeStore.Controllers
{
    public class TemproryController : Controller
    {
        // GET: Temprory
        public ActionResult Temp1()
        {
           
            return View();
        }
        [HttpGet]
        public JsonResult GetStudent()
        {
            TempModel std = new TempModel()
            {
                id = 1,
                name = "std1"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}