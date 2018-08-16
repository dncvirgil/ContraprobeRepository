using Contraprobe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Contraprobe.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(ProductModel product)
        {
            ProductRepository p = new ProductRepository();
            p.Add(product);
            return RedirectToAction("List");
        }

        //public ActionResult List()
        //{
        //    ProductRepository p = new ProductRepository();
        //    List<ProductModel> listaProduse = p.List();
        //    return View(listaProduse);
        //}


        public ActionResult List(int page = 1)
        {
            int pageSize = 10;
            int pageNumber = page;
            ProductRepository p = new ProductRepository();
            List<ProductModel> listaProduse = p.List();
            var model = listaProduse.ToPagedList(pageNumber, pageSize);
            return View(model);
        }



        public ActionResult Delete(int id)
        {
            ProductRepository p = new ProductRepository();
            p.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            ProductRepository p = new ProductRepository();
            return View(p.Details(id));
        }

        // Get
        public ActionResult Edit(int id)
        {
            ProductRepository p = new ProductRepository();
            return View(p.Details(id));
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            ProductRepository p = new ProductRepository();
            p.Edit(product);
            return RedirectToAction("List");
        }

    }
}