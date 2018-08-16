using Contraprobe.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contraprobe.Controllers
{
    public class SampleController : Controller
    {
        // GET: Drug
        public ActionResult Add()
        {
            // creez o lista <SelectListItem> pentru a popula dropdown-ul cu denumirea produselor din baza de date
            ProductRepository p = new ProductRepository();
            var listaProduse = p.List();
            List<SelectListItem> dropdownProduse = new List<SelectListItem>();
            foreach (var item in listaProduse)
            {
                dropdownProduse.Add(new SelectListItem { Value = item.Name, Text = item.Name});
            }

            // trimit lista spre view
            ViewBag.Produse = dropdownProduse;

            return View();
        }

        [HttpPost]
        public ActionResult Add(SampleModel drug)
        {
            SampleRepository r = new SampleRepository();
            r.Add(drug);
            return RedirectToAction("List");
        }

        public ActionResult List(int page = 1)
        {
            int pageSize = 10;
            int pageNumber = page;
            SampleRepository r = new SampleRepository();
            var sampleList = r.GetAll();
            var model = sampleList.ToPagedList(pageNumber, pageSize);
            return View(model);
        }

        public ActionResult Delete (int id)
        {
            SampleRepository r = new SampleRepository();
            r.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            SampleRepository r = new SampleRepository();
            
            return View(r.Details(id));
        }

        // Get
        public ActionResult Edit (int id)
        {
            SampleRepository r = new SampleRepository();
            return View(r.Details(id));
        }

        [HttpPost]
        public ActionResult Edit(SampleModel drug)
        {
            SampleRepository r = new SampleRepository();
            r.Edit(drug);
            return RedirectToAction("List");
        }
    }
}