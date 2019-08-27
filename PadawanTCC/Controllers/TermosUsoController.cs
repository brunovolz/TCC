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
using PadawanTCC.Models;

namespace PadawanTCC.Controllers
{
    public class TermosUsoController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TermosUso
        public IQueryable<TermoUso> GettermosDeUso()
        {
            return db.termosDeUso;
        }

        // GET: api/TermosUso/5
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> GetTermoUso(int id)
        {
            TermoUso termoUso = await db.termosDeUso.FindAsync(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            return Ok(termoUso);
        }

        // PUT: api/TermosUso/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermoUso(int id, TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoUso.Id)
            {
                return BadRequest();
            }

            db.Entry(termoUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoUsoExists(id))
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

        // POST: api/TermosUso
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> PostTermoUso(TermoUso termoUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.termosDeUso.Add(termoUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termoUso.Id }, termoUso);
        }

        // DELETE: api/TermosUso/5
        [ResponseType(typeof(TermoUso))]
        public async Task<IHttpActionResult> DeleteTermoUso(int id)
        {
            TermoUso termoUso = await db.termosDeUso.FindAsync(id);
            if (termoUso == null)
            {
                return NotFound();
            }

            db.termosDeUso.Remove(termoUso);
            await db.SaveChangesAsync();

            return Ok(termoUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoUsoExists(int id)
        {
            return db.termosDeUso.Count(e => e.Id == id) > 0;
        }
    }
}