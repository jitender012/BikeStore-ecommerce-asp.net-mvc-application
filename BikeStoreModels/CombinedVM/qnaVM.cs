using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels.CombinedVM
{
    public class qnaVM
    {
        public int qus_id { get; set; }
        public string qus_text { get; set; }
        public int c_id { get; set; }
        public int p_id { get; set; }
        public System.DateTime date { get; set; }       
    }
}
