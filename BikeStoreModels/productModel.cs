using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.IO;


namespace BikeStoreModels
{
    public class productModel
    {
        public int product_id { get; set; }

        [Display(Name ="Product Name")]
        public string product_name { get; set; }

        [Display(Name = "Brand")]
        public int brand_id { get; set; }

        [Display(Name = "Category")]
        public int category_id { get; set; }

        [Display(Name = "Model Year")]
        public short model_year { get; set; }

        [Display(Name = "Price")]
        public decimal list_price { get; set; }

        [Display(Name = "Description")]
        [MaxLength(1000)]
        public string description { get; set; }
        [MaxLength(1000)]
        [Display(Name = "URL")]
        public string url { get; set; }
        public virtual brandModel brand { get; set; }
        public virtual categoryModel category { get; set; }

        public virtual ask_qustionModel ask_qustion { get; set; }
}
}
