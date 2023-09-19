using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreModels
{
    public class UserRoleModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string Role { get; set; }

        public virtual customerModel customer { get; set; }
    }
}
