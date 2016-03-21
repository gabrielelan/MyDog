using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDog.Models;

namespace MyDog.Controllers
{
    public class CaniController : Controller
    {
        // GET: Cani
        public ActionResult Index()
        {
            List<Cani> model = new List<Cani>();
            using (DOG_DBEntities db = new DOG_DBEntities())
            {
                model = db.Cani.ToList();
            }
            //return dogs list
            return View(model);
        }

        // GET: Cani/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //GET: Cani/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cani/Create
        [HttpPost]
        public ActionResult Create(Cani cane)
        {
            try
            {
                cane.IdCategoria = 1;
                using (DOG_DBEntities db = new DOG_DBEntities())
                {
                    db.Cani.Add(cane);
                    db.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Cani/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: Cani/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Cani/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Cani/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
