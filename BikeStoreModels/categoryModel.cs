using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
    public class categoryModel
    {
        [Key]
        [Display(Name = "Category ID")]
        public int category_id { get; set; }
        [Display(Name = "Category Name")]
        public string category_name { get; set; }
    }
}
