using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBFree.Models;

namespace IBFree.Controllers
{
    public class BadFoodsController : Controller
    {
        private IBFreeContext db = new IBFreeContext();

        public ActionResult BadFoodList()
        {
            var foods = db.BadFood.ToList();
            return View(foods);
        }

        // GET: BadFoods
        public ActionResult Index()
        {
            return View(db.BadFood.ToList());
        }

        // GET: BadFoods/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badFoods = db.BadFood.Find(id);
            if (badFoods == null)
            {
                return HttpNotFound();
            }
            return View(badFoods);
        }

        // GET: BadFoods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadFoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NameId,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose")] BadFoods badFoods)
        {
            if (ModelState.IsValid)
            {
                db.BadFood.Add(badFoods);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badFoods);
        }

        // GET: BadFoods/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badFoods = db.BadFood.Find(id);
            if (badFoods == null)
            {
                return HttpNotFound();
            }
            return View(badFoods);
        }

        // POST: BadFoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NameId,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose")] BadFoods badFoods)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badFoods).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badFoods);
        }

        // GET: BadFoods/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badFoods = db.BadFood.Find(id);
            if (badFoods == null)
            {
                return HttpNotFound();
            }
            return View(badFoods);
        }

        // POST: BadFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BadFoods badFoods = db.BadFood.Find(id);
            db.BadFood.Remove(badFoods);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
