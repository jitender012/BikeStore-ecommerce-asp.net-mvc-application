using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
    public class staffModel
    {
        [Display(Name = "Staff ID")]
        public int staff_id { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Display(Name = "Email ID")]
        public string email { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Active")]
        public byte active { get; set; }
        [Display(Name = "Store ID")]
        public int store_id { get; set; }
        [Display(Name = "Manager ID")]
        public Nullable<int> manager_id { get; set; }
    }
}
