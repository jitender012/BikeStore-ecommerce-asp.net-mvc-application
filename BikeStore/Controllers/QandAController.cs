using BikeStoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeStoreDB.DbOperations;
using Newtonsoft.Json;

namespace BikeStore.Controllers
{
    public class QandAController : Controller
    {
        AskQuestionRepository repository = null;
        public QandAController()
        {
            repository = new AskQuestionRepository();
        }


        [HttpPost]
        public ActionResult AddQus(ask_qustionModel ak)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddQuestion(ak);
                if (id > 0)
                {
                    ModelState.Clear();                   
                }
            }
            return View();
        }

        public JsonResult GetQus()
        {
            var qus = repository.GetAllQustions();
            var qus2 = new ask_qustionModel()
            {
                qus_text = "height?",
                c_email = " jk@gmail.com",
                date = DateTime.Now.Date
            };

            var json = JsonConvert.SerializeObject(qus);
            return Json(json, JsonRequestBehavior.AllowGet);
        }


    }
}
