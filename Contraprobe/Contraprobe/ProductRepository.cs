using Contraprobe.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contraprobe
{
    public class ProductRepository
    {
        public void Add(ProductModel model)
        {
            using (var db = new LiteDatabase(@"c:/ContraprobeDB/Contraprobe.db"))
            {
                var products = db.GetCollection<ProductModel>("products");
                products.Insert(model);

            }
        }


        public List<ProductModel> List()
        {
            using (var db = new LiteDatabase(@"c:/ContraprobeDB/Contraprobe.db"))
            {
                var products = db.GetCollection<ProductModel>("products");
                return products.FindAll().ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                var products = db.GetCollection<ProductModel>("products");
                products.Delete(id);
            }
        }

        public ProductModel Details(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                var products = db.GetCollection<ProductModel>("products");
                var product =  products.FindById(id);

                return product;
            }
        }

        public void Edit(ProductModel product)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                var products = db.GetCollection<ProductModel>("products");
                products.Update(product);
            }
        }
    }
}