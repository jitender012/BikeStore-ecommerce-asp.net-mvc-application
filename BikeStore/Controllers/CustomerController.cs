using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BikeStoreModels;
using BikeStoreDB.DbOperations;

namespace BikeStore.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository repository = null;
        public CustomerController()
        {
            repository = new CustomerRepository();
        }
        // GET: Customer

        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            //var states = new List<string> { "Andaman and Nicobar Islands", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Delhi", "Dadra and Nagar Haveli and Daman and Diu", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Ladakh", "Lakshadweep", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Puducherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal" };
            //ViewBag.statelist = states;
            CombinedClass cc = new CombinedClass()
            {
                role = "member"
            };
            return View(cc);
        }
        [HttpPost]
        public ActionResult Create(CombinedClass model)
        {
            //var states = new List<string> { "Andaman and Nicobar Islands", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Delhi", "Dadra and Nagar Haveli and Daman and Diu", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Ladakh", "Lakshadweep", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Puducherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal" };

            if (ModelState.IsValid)
            {
                int id = repository.CreateCustomer(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    TempData["successmessage"] = "Account Created";
                }
            }
            if (ModelState.IsValid)
            {
                int cid = repository.getCid(model);
                repository.AddRole(cid, model.role);
            }
            return View();
        }
        [Authorize]
        public ActionResult CustomerProfile(string email)
        {
            var customer_details = repository.GetCustomerDetails(email);
            return View(customer_details);
        } 

        public string GetCustomerName(string  email)
        {
            var customer_details = repository.getCustomerName(email);
           return customer_details;
        }

        [HttpPost]
        public ActionResult CustomerProfile(customerModel customer)
        {
            if (ModelState.IsValid)
            {
                var customer_details = repository.UpdateCustomerDetails(customer.customer_id, customer);

                return View(customer_details);
            }
            
                return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(customerModel model)
        {
            bool isValid = repository.isValid(model);
            if (isValid)
            {
                
                FormsAuthentication.SetAuthCookie(model.email, false);
                TempData["SuccessMessage"] = "Login successfully";
                return RedirectToAction("Home", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View(model);
            }
        
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();            
            return RedirectToAction("Home", "Home");
        }

    }
}