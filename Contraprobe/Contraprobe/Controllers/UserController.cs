using Contraprobe.Models;
using Microsoft.AspNet.Identity.Owin;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Contraprobe.Controllers
{
    public class UserController : Controller
    {
        // Login
        // GET: /User/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("Login");
        }

        // POST: /User/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            UserRepository u = new UserRepository();
            var useri = u.GetAll();


            if (ModelState.IsValid)
            {
                foreach (var user in useri)
                {
                    if (user.Email == model.Email && user.Password == model.Password)
                    {
                        return RedirectToAction("Index","Home");
                    }
                }
                ViewBag.ErrorMessage = "Username sau parola incorecte!";
                return View();
            }
            ViewBag.ErrorMessage = "Username sau parola incorecte!";
            return View();
        }



        [AllowAnonymous]
        public ActionResult Logoff()
        {
            return RedirectToAction("Login");
        }

        // Register
        // GET: /User/Register
        [AllowAnonymous]
        public ActionResult Add()
        {
            return View();
        }

        //
        // POST: /User/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Add(UserModel user)
        {
            UserRepository u = new UserRepository();
            u.Add(user);

            return RedirectToAction("List");
        }


        //public ActionResult List()
        //{
        //    UserRepository u = new UserRepository();
        //    return View(u.GetAll());
        //}



        //https://www.c-sharpcorner.com/blogs/simple-paging-in-mvc
        public ActionResult List(int page = 1)
        {
            int pageSize = 10;
            int pageNumber = page;
            UserRepository u = new UserRepository();
            var model = u.GetAll().ToPagedList(pageNumber, pageSize);

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            UserRepository u = new UserRepository();
            u.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserRepository u = new UserRepository();
            UserModel user = u.Details(id);
            return View(user); ;
        }


        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            UserRepository u = new UserRepository();
            u.Edit(user);
            return RedirectToAction("List");
        }

    }
}