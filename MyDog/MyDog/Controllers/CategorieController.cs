using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDog.Models;

namespace MyDog.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        public ActionResult Index(int idCategoriaCane)
        {
            //ViewBag.idCategoriaCane = idCategoriaCane;
            Categorie categoria = new Categorie();
            DOG_DBEntities db = new DOG_DBEntities();

            // Query for all blogs with names starting with B 
            Categorie category = (from Categorie c in db.Categorie
                where c.Id.Equals(idCategoriaCane)
                select c).First();

            return View(category);
        }
    }
}