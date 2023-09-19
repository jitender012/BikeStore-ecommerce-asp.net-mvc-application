using BikeStoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreDB.DbOperations
{
    public class BrandRepository
    {
        BikeStores_2Entities context = new BikeStores_2Entities();
        public List<brandModel> GetAllBrands()
        {
            //using (var context = new BikeStores_2Entities())
            //{
            var result = context.brands.Select(x => new brandModel()
            {
                brand_id = x.brand_id,
                brand_name = x.brand_name
            }).ToList();                
                return result;            
        }

        public int AddBrand(brandModel model)
        {
            var result = new brand()
            {
                brand_id = model.brand_id,
                brand_name = model.brand_name
            };

            context.brands.Add(result);
            context.SaveChanges();
            return result.brand_id;
        }

        public bool DeleteBrand(int id)
        {

            var result = context.brands.FirstOrDefault(x => x.brand_id == id);
            if (result != null)
            {

                context.brands.Remove(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public brandModel GetBrandDetails(int id)
        {            
                var result = context.brands.Where(x => x.brand_id == id).Select(x => new brandModel
                {
                    brand_id = x.brand_id,
                    brand_name = x.brand_name
                }).FirstOrDefault();
                return result;
        }

    }
    
}
