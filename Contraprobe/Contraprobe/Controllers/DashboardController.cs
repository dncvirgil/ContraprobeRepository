using Contraprobe.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contraprobe.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dasboard
        public ActionResult Index(int page = 1)
        {
            int pageSize = 10;
            int pageNumber = page;
            List<SampleModel> listSamples = new List<SampleModel>();
            SampleRepository s = new SampleRepository();
            listSamples = s.GetAll();

            var model = listSamples.ToPagedList(pageNumber, pageSize);
            return View(model);
        }


        [HttpPost]
        public ActionResult Search(SearchModel model)
        {
            int pageSize = 10;
            int pageNumber = 1;
            SampleRepository s = new SampleRepository();
            var listSample = s.Search(model);
            var pagedList = listSample.ToPagedList(pageNumber, pageSize);

            return View("Index", pagedList);
        }
    }
}