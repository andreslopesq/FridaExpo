using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Frida.WebApplication.Models;

namespace Frida.WebApplication.Controllers
{
    public class VisitantesController : ApiController
    {
        private FridaDBContext db = new FridaDBContext();

        // GET: api/Visitantes
        public IQueryable<visitante> Getvisitantes()
        {
            return db.visitantes;
        }

        // GET: api/Visitantes/5
        [ResponseType(typeof(visitante))]
        public async Task<IHttpActionResult> Getvisitante(int id)
        {
            visitante visitante = await db.visitantes.FindAsync(id);
            if (visitante == null)
            {
                return NotFound();
            }

            return Ok(visitante);
        }

        // PUT: api/Visitantes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putvisitante(int id, visitante visitante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visitante.idVisitante)
            {
                return BadRequest();
            }

            db.Entry(visitante).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!visitanteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Visitantes
        [ResponseType(typeof(visitante))]
        public async Task<IHttpActionResult> Postvisitante(visitante visitante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.visitantes.Add(visitante);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = visitante.idVisitante }, visitante);
        }

        // DELETE: api/Visitantes/5
        [ResponseType(typeof(visitante))]
        public async Task<IHttpActionResult> Deletevisitante(int id)
        {
            visitante visitante = await db.visitantes.FindAsync(id);
            if (visitante == null)
            {
                return NotFound();
            }

            db.visitantes.Remove(visitante);
            await db.SaveChangesAsync();

            return Ok(visitante);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool visitanteExists(int id)
        {
            return db.visitantes.Count(e => e.idVisitante == id) > 0;
        }
    }
}