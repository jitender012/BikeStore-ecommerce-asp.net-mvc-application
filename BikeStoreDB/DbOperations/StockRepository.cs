using BikeStoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreDB.DbOperations
{
    class StockRepository
    {
        //public int AddProduct(stockModel model)
        //{
        //    using (var db = new BikeStores_2Entities())
        //    {
        //        stock st = new stock()
        //        {
        //            quantity = st.quantity,

        //        };

        //        db.stocks.Add(st);
        //        db.SaveChanges();

        //        return st.stoc;
        //    }
        //}

        //public List<productModel> GetAllProducts()
        //{
        //    using (var context = new BikeStores_2Entities())
        //    {
        //        var result = context.products.Select(model => new productModel()
        //        {
        //            product_id = model.product_id,
        //            product_name = model.product_name,
        //            model_year = model.model_year,
        //            list_price = model.list_price,
        //            description = model.description,
        //            url = model.url,
        //            brand = new brandModel()
        //            {
        //                brand_name = model.brand.brand_name,
        //                brand_id = model.brand.brand_id
        //            },
        //            category = new categoryModel()
        //            {
        //                category_name = model.category.category_name,
        //                category_id = model.category.category_id
        //            }
        //        }).ToList();

        //        return result;
        //    }
        //}

        //public productModel GetProductDetails(int id)
        //{
        //    using (var context = new BikeStores_2Entities())
        //    {
        //        var result = context.products.Where(x => x.product_id == id).Select(x => new productModel
        //        {
        //            product_id = x.product_id,
        //            product_name = x.product_name,
        //            list_price = x.list_price,
        //            model_year = x.model_year,
        //            description = x.description,
        //            url = x.url,

        //            brand = new brandModel()
        //            {
        //                brand_id = x.brand.brand_id,
        //                brand_name = x.brand.brand_name
        //            },
        //            category = new categoryModel()
        //            {
        //                category_id = x.category.category_id,
        //                category_name = x.category.category_name
        //            }
        //        }).FirstOrDefault();
        //        return result;
        //    }

        //}

        //public bool UpdateProductDetails(int id, stockModel model)
        //{
        //    using (var context = new BikeStores_2Entities())
        //    {
        //        var prod = context.products.FirstOrDefault(x => x.product_id == id);

        //        if (prod != null)
        //        {
        //            prod.product_name = model.product_name;
        //            prod.list_price = model.list_price;
        //            prod.model_year = model.model_year;
        //            prod.description = model.description;
        //            prod.url = model.url;

        //        }

        //        context.SaveChanges();
        //        return true;
        //    }


        //}

        //public bool DeleteProduct(int id)
        //{
        //    using (var context = new BikeStores_2Entities())
        //    {
        //        var result = context.products.FirstOrDefault(x => x.product_id == id);

        //        if (result != null)
        //        {
        //            context.products.Remove(result);
        //            context.SaveChanges();
        //            return true;
        //        }
        //        return false;
        //    }
        //}
    }
}
