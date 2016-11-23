using Data.Infrastructure;
using Domain.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            

            return View();
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(category cat)
        {

            CategoryServices cs = new CategoryServices();
            cs.Add(cat);
            cs.Commit();
                
             
                return RedirectToAction("Categories","Home");
           
           
            
        }

        // GET: Categories/Edit
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categories/Edit
        [HttpPost]
        public ActionResult Edit(category c)
        {
            try
            {
                CategoryServices cs = new CategoryServices();
                category nc = cs.GetById(c.id);
                nc.name = c.name;
                cs.Update(nc);
                cs.Commit();

                return RedirectToAction("Categories", "Home");
            }
            catch
            {
                return RedirectToAction("Categories", "Home");
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            CategoryServices cs = new CategoryServices();
            cs.Delete(cs.GetById(id));
            cs.Commit();
            return RedirectToAction("Categories", "Home");
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Categories","Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
