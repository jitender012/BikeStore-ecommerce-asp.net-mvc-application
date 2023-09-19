using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
   public class orderModel
    {
        public int order_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public byte order_status { get; set; }
        public System.DateTime order_date { get; set; }
        public System.DateTime required_date { get; set; }
        public Nullable<System.DateTime> shipped_date { get; set; }
        public int store_id { get; set; }
        public int staff_id { get; set; }
    }
}
