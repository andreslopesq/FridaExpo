using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FridaExpo.Web.Models;

namespace FridaExpo.Web.Controllers
{
    public class VisitantesController : Controller
    {
        private FridaExpoDBContext db = new FridaExpoDBContext();

        // GET: Visitantes
        public async Task<ActionResult> Index()
        {
            return View(await db.visitantes.ToListAsync());
        }

        // GET: Visitantes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visitante visitante = await db.visitantes.FindAsync(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // GET: Visitantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idVisitante,nombreCliente,nombreNegocio,domicilio,noExt,colonia,cp,localidad,estado,tel,cel,celDos,email,fechaRegistro,folioVisita,idCliente")] visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.visitantes.Add(visitante);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(visitante);
        }

        // GET: Visitantes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visitante visitante = await db.visitantes.FindAsync(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idVisitante,nombreCliente,nombreNegocio,domicilio,noExt,colonia,cp,localidad,estado,tel,cel,celDos,email,fechaRegistro,folioVisita,idCliente")] visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitante).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(visitante);
        }

        // GET: Visitantes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visitante visitante = await db.visitantes.FindAsync(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            visitante visitante = await db.visitantes.FindAsync(id);
            db.visitantes.Remove(visitante);
            await db.SaveChangesAsync();
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
