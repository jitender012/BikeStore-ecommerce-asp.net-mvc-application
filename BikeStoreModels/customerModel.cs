using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BikeStoreModels
{
    public class customerModel
    {

        public int customer_id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string first_name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required]
        [Display(Name = "Phone No.")]
        public string phone { get; set; }

        [Required]
        [Display(Name = "Email ID")]
        public string email { get; set; }

        [Display(Name = "Street")]
        public string street { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }
        
        [Display(Name = "State")]
        public string state { get; set; }
        
        [Display(Name = "Zip Code")]
        public string zip_code { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }
        public virtual UserRoleModel userRole { get; set; }
    }
}
