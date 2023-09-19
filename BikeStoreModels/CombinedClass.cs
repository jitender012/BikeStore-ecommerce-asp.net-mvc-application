using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
    public class CombinedClass
    {
        public int customer_id { get; set; }

        
        [Required]
        [Display(Name = "First Name")]
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
        public int role_id { get; set; }        
        public string role { get; set; }

        public virtual customerModel customer { get; set; }
    }
}
