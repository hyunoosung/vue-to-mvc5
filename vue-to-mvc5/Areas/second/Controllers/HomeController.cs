using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vue_to_mvc5.Areas.second.Controllers
{
    public class HomeController : Controller
    {
        // GET: second/Second
        public ActionResult Index()
        {
            return View();
        }

        // GET: second/Second/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: second/Second/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: second/Second/Create
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

        // GET: second/Second/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: second/Second/Edit/5
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

        // GET: second/Second/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: second/Second/Delete/5
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
