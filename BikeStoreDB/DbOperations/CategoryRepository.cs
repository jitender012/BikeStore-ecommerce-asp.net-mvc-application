using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeStoreDB;
using BikeStoreModels;

namespace BikeStoreDB.DbOperations
{
    public class CategoryRepository
    {
        public int CreateCategory(categoryModel model)
        {
            using (var context = new BikeStores_2Entities())
            {
                category cat = new category()
                {
                    category_name = model.category_name
                };
                context.categories.Add(cat);
                context.SaveChanges();
                return cat.category_id;
            }
        }

        public List<categoryModel> GetAllCategories()
        {
            using (var context = new BikeStores_2Entities())
            {
                var result = context.categories.Select(x => new categoryModel
                {
                    category_id = x.category_id,
                    category_name = x.category_name
                }).ToList();
            return result;
            }
        }
    }
}
