using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
    public class stockModel
    {
        [Display(Name = "Store ID")]
        public int store_id { get; set; }
        [Display(Name = "Product ID")]
        public int product_id { get; set; }
        [Display(Name = "Quantity")]
        public Nullable<int> quantity { get; set; }

        public virtual productModel product { get; set; }
        public virtual storeModel store { get; set; }
    }
}
