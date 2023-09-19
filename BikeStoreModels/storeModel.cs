using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BikeStoreModels
{
    public class storeModel
    {
        
        [Display(Name ="Store ID")]
        public int store_id { get; set; }

        [Display(Name = "Store Name")]
        public string store_name { get; set; }

        [Display(Name = "Phone Number")]
       
        public string phone { get; set; }

        [Display(Name = "Email ID")]
        public string email { get; set; }

        [Display(Name = "Street")]
        public string street { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        
        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(8)]
        public string zip_code { get; set; }
    }
}
