using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vue_to_mvc5.Areas.first.Controllers
{
    public class HomeController : Controller
    {
        // GET: first/Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: first/Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: first/Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: first/Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: first/Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: first/Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: first/Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: first/Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
