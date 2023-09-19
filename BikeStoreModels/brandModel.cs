using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BikeStoreModels
{
    public class brandModel
    {
        [Key]
        [Display(Name = "Brand ID")]
        public int brand_id { get; set; }
        [Display(Name = "Brand Name")]
        public string brand_name { get; set; }
    }
}
