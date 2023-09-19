using BikeStoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreDB.DbOperations
{
    public class StoreRepository
    {
        BikeStores_2Entities context = new BikeStores_2Entities();

        public int AddStore(storeModel model)
        {
            store st = new store()
            {
                store_id = model.store_id,
                store_name = model.store_name,
                phone = model.phone,
                email = model.email,
                street = model.street,
                city = model.city,
                state = model.state,
                zip_code = model.zip_code
            };

            context.stores.Add(st);
            context.SaveChanges();

            return st.store_id;
        }


        public List<storeModel> GetAllStores()
        {
            var result = context.stores.Select(model => new storeModel()
            {
                store_id = model.store_id,
                store_name = model.store_name,
                phone = model.phone,
                email = model.email,
                street = model.street,
                city = model.city,
                state = model.state,
                zip_code = model.zip_code
            }).ToList();
            return result;
        }

        public storeModel GetStoreDetails(int id)
        {
            var result = context.stores.Where(x => x.store_id == id).Select(model => new storeModel
            {
                store_id = model.store_id,
                store_name = model.store_name,
                phone = model.phone,
                email = model.email,
                street = model.street,
                city = model.city,
                state = model.state,
                zip_code = model.zip_code
            }).FirstOrDefault();
            return result;
        }

        public bool UpdateStoreDetails(int id, storeModel model)
        {
            var st = context.stores.FirstOrDefault(x => x.store_id == id);

            if (st != null)
            {
                st.store_id = model.store_id;
                st.store_name = model.store_name;
                st.phone = model.phone;
                st.email = model.email;
                st.street = model.street;
                st.city = model.city;
                st.state = model.state;
                st.zip_code = model.zip_code;

            };
            context.SaveChanges();
            return true;
        }

        public bool DeleteStore(int id)
        {
            var result = context.stores.FirstOrDefault(x => x.store_id == id);

            if (result != null)
            {
                context.stores.Remove(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
