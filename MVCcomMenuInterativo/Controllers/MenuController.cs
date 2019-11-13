using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCcomMenuInterativo.Models;

namespace MVCcomMenuInterativo.Controllers
{
    public class MenuController : Controller
    {
        private ContextoDados db = new ContextoDados();

        // GET: Menu
        public ActionResult Index()
        {
            return View(db.ItensDeMenu.ToList());
        }

        // GET: Menu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeMenu itemDeMenu = db.ItensDeMenu.Find(id);
            if (itemDeMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemDeMenu);
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menu/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemDeMenuId,ItemPaiId,NomeDoItem,NomeDoController,NomeDaAction")] ItemDeMenu itemDeMenu)
        {
            if (ModelState.IsValid)
            {
                db.ItensDeMenu.Add(itemDeMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemDeMenu);
        }

        // GET: Menu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeMenu itemDeMenu = db.ItensDeMenu.Find(id);
            if (itemDeMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemDeMenu);
        }

        // POST: Menu/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemDeMenuId,ItemPaiId,NomeDoItem,NomeDoController,NomeDaAction")] ItemDeMenu itemDeMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemDeMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemDeMenu);
        }

        // GET: Menu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemDeMenu itemDeMenu = db.ItensDeMenu.Find(id);
            if (itemDeMenu == null)
            {
                return HttpNotFound();
            }
            return View(itemDeMenu);
        }

        // POST: Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemDeMenu itemDeMenu = db.ItensDeMenu.Find(id);
            db.ItensDeMenu.Remove(itemDeMenu);
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
