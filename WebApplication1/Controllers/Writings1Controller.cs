using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Writings1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Writings1
        public ActionResult Index()
        {
            return View(db.Writings.ToList());
        }

        // GET: Writings1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Writing writing = db.Writings.Find(id);
            if (writing == null)
            {
                return HttpNotFound();
            }
            return View(writing);
        }

        // GET: Writings1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Writings1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,userId,text,title")] Writing writing)
        {
            if (ModelState.IsValid)
            {
                db.Writings.Add(writing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(writing);
        }

        // GET: Writings1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Writing writing = db.Writings.Find(id);
            if (writing == null)
            {
                return HttpNotFound();
            }
            return View(writing);
        }

        // POST: Writings1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,userId,text,title")] Writing writing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(writing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(writing);
        }

        // GET: Writings1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Writing writing = db.Writings.Find(id);
            if (writing == null)
            {
                return HttpNotFound();
            }
            return View(writing);
        }

        // POST: Writings1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Writing writing = db.Writings.Find(id);
            db.Writings.Remove(writing);
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
