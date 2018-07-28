using Contraprobe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contraprobe.Controllers
{
    public class DrugController : Controller
    {
        // GET: Drug
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(DrugModel drug)
        {
            DrugRepository r = new DrugRepository();
            r.Add(drug);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            DrugRepository r = new DrugRepository();
            return View(r.GetAll());
        }

        public ActionResult Delete (int id)
        {
            DrugRepository r = new DrugRepository();
            r.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            DrugRepository r = new DrugRepository();
            
            return View(r.Details(id));
        }

        // Get
        public ActionResult Edit (int id)
        {
            DrugRepository r = new DrugRepository();
            return View(r.Details(id));
        }

        [HttpPost]
        public ActionResult Edit(DrugModel drug)
        {
            DrugRepository r = new DrugRepository();
            r.Edit(drug);
            return RedirectToAction("List");
        }
    }
}