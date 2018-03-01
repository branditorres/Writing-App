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
    public class ProjectInfoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ProjectInfoes
        public ActionResult Index()
        {
            return View(db.ProjectInfoes.ToList());
        }

        // GET: ProjectInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectInfo projectInfo = db.ProjectInfoes.Find(id);
            if (projectInfo == null)
            {
                return HttpNotFound();
            }
            return View(projectInfo);
        }

        // GET: ProjectInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,userId,projectTitle,dateCreated,genre,type,progress,wordCount,triggerWs,charasInvolved")] ProjectInfo projectInfo)
        {
            if (ModelState.IsValid)
            {
                db.ProjectInfoes.Add(projectInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectInfo);
        }

        // GET: ProjectInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectInfo projectInfo = db.ProjectInfoes.Find(id);
            if (projectInfo == null)
            {
                return HttpNotFound();
            }
            return View(projectInfo);
        }

        // POST: ProjectInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,userId,projectTitle,dateCreated,genre,type,progress,wordCount,triggerWs,charasInvolved")] ProjectInfo projectInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectInfo);
        }

        // GET: ProjectInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectInfo projectInfo = db.ProjectInfoes.Find(id);
            if (projectInfo == null)
            {
                return HttpNotFound();
            }
            return View(projectInfo);
        }

        // POST: ProjectInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectInfo projectInfo = db.ProjectInfoes.Find(id);
            db.ProjectInfoes.Remove(projectInfo);
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
