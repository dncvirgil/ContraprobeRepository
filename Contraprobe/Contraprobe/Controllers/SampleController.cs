using Contraprobe.Models;
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
            return View();
        }

        [HttpPost]
        public ActionResult Add(SampleModel drug)
        {
            SampleRepository r = new SampleRepository();
            r.Add(drug);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            SampleRepository r = new SampleRepository();
            return View(r.GetAll());
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