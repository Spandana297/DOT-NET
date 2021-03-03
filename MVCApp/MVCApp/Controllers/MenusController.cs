﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModel;

namespace MVCApp.Controllers
{
    public class MenusController : Controller
    {
        private MenuContext db = new MenuContext();

        // GET: Menus
        public ActionResult Index()
        {
            return View(db.menudetailes.ToList());
        }

        // GET: Menus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu menu = db.menudetailes.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        // GET: Menus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Cusine_Name,Cusine_Type,Cost")] MenuViewModel menumodel)
        {
            if (ModelState.IsValid)
            {
                Menu menu = new Menu
                {
                    ID = menumodel.ID,
                    Cusine_Name = menumodel.Cusine_Name,
                    Cusine_Type = menumodel.Cusine_Type,
                    Cost = menumodel.Cost

                };
                db.menudetailes.Add(menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menumodel);
        }

        // GET: Menus/Edit/5
        public PartialViewResult MenuEdit(int? id)
        {
            
            Menu menu = db.menudetailes.Find(id);
           
            return PartialView("_MenuEdit",menu);
        }

        // POST: Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Cusine_Name,Cusine_Type,Cost")] Menu menu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menu);
        }

        // GET: Menus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu menu = db.menudetailes.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        // POST: Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menu menu = db.menudetailes.Find(id);
            db.menudetailes.Remove(menu);
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
