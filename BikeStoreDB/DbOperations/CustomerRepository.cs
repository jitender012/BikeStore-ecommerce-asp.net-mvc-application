using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeStoreModels;

namespace BikeStoreDB.DbOperations
{
    public class CustomerRepository
    {
        BikeStores_2Entities db = new BikeStores_2Entities();

        public int CreateCustomer(CombinedClass model)
        {
            customer customer = new customer()
            {                
                first_name = model.first_name,
                last_name = model.last_name,
                phone = model.phone,
                email = model.email,
                street = model.street,
                city = model.city,
                state = model.state,
                zip_code = model.zip_code,
                password = model.password,
                      
            };
            db.customers.Add(customer);
            db.SaveChanges();                  
            return customer.customer_id;

        }

       
        public customerModel GetCustomerDetails(string email)
        {
            var result = db.customers.Where(x => x.email == email).Select(model => new customerModel
            {
                first_name = model.first_name,
                last_name = model.last_name,
                phone = model.phone,
                email = model.email,
                street = model.street,
                city = model.city,
                state = model.state,
                zip_code = model.zip_code,
                password = model.password,
            }).FirstOrDefault();
            return result;
        }
        public string getCustomerName(string email)
        {
            var result = db.customers.Where(x => x.email == email).Select(model => new customerModel
            {
                first_name = model.first_name,
                last_name = model.last_name,
               
            }).FirstOrDefault();
            string fname = result.first_name + " " + result.last_name;
            return fname;
        }
        public bool UpdateCustomerDetails(int id, customerModel model)
        {
            var customer = db.customers.FirstOrDefault(x => x.customer_id== id);

            if (customer != null)
            {
                customer.first_name = model.first_name;
                customer.last_name = model.last_name;
                customer.phone = model.phone;
                customer.email = model.email;
                customer.street = model.street;
                customer.city = model.city;
                customer.state = model.state;
                customer.zip_code = model.zip_code;
                customer.password = model.password;

            }

            db.SaveChanges();
            return true;
        }
        public int getCid(CombinedClass model)
        {
            var result = db.customers.Where(x => x.email == model.email && x.phone == model.phone).FirstOrDefault();
            return result.customer_id;
        }

        public int AddRole(int c_id, string role_name)
        {
            UserRole ur = new UserRole();
            if (c_id > 0)
            {
                ur.role = role_name;
                ur.customer_id = c_id;                
            }
            db.UserRoles.Add(ur);
            db.SaveChanges();
            return 0;            
        }

        public bool isValid(customerModel model)
        {
            customer customer = new customer();
            bool isvalid = db.customers.Any(x => x.email == model.email && x.password == model.password);
            if (isvalid)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
