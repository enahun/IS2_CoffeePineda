using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationBodegaPineda.DB;

namespace WebApplicationBodegaPineda.Controllers
{
    public class DepositoesController : Controller
    {
        private BodegaPinedaEntities db = new BodegaPinedaEntities();

        // GET: Depositoes
        public ActionResult Index()
        {
            return View(db.Depositos.ToList());
        }

        // GET: Depositoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deposito deposito = db.Depositos.Find(id);
            if (deposito == null)
            {
                return HttpNotFound();
            }
            return View(deposito);
        }

        // GET: Depositoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Depositoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDepositos,idUser")] Deposito deposito)
        {
            if (ModelState.IsValid)
            {
                db.Depositos.Add(deposito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deposito);
        }

        // GET: Depositoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deposito deposito = db.Depositos.Find(id);
            if (deposito == null)
            {
                return HttpNotFound();
            }
            return View(deposito);
        }

        // POST: Depositoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDepositos,idUser")] Deposito deposito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deposito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deposito);
        }

        // GET: Depositoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deposito deposito = db.Depositos.Find(id);
            if (deposito == null)
            {
                return HttpNotFound();
            }
            return View(deposito);
        }

        // POST: Depositoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Deposito deposito = db.Depositos.Find(id);
            db.Depositos.Remove(deposito);
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
