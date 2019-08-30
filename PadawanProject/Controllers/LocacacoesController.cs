using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PadawanProject.Models;

namespace PadawanProject.Controllers
{
    public class LocacacoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Locacacoes
        public IQueryable<Locacao> GetLocacoes()
        {
            return db.Locacoes.Where(x => x.Ativo == true); 
        }

        // GET: api/Locacacoes/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> GetLocacao(int id)
        {
            Locacao locacao = await db.Locacoes.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            return Ok(locacao);
        }

        // PUT: api/Locacacoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocacao(int id, Locacao locacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locacao.Id)
            {
                return BadRequest();
            }

            db.Entry(locacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocacaoExists(id))
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

        // POST: api/Locacacoes
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> PostLocacao(Locacao locacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            locacao.TermoUsoId = db.TermosUso.FirstOrDefault(x => x.Ativo == true).Id;
            
            locacao.StatusLocacaoFK = 2;
            
            db.Locacoes.Add(locacao);
            await db.SaveChangesAsync();

            //return CreatedAtRoute("DefaultApi", new { id = locacao.Id }, locacao);
            return Ok("Sua intenção de locação foi realizada com sucesso!  " +
                "  Entraremos em contato para confirmar e seguir com as orientações de acesso");
        }

        // DELETE: api/Locacacoes/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> DeleteLocacao(int id)
        {
            Locacao locacao = await db.Locacoes.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            locacao.Ativo = false;
            db.SaveChanges();

            return Ok(locacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocacaoExists(int id)
        {
            return db.Locacoes.Count(e => e.Id == id) > 0;
        }
        public static string EnviarEmailAprovados(string emailEnviarPara)
        {
            string seuEmail = "koyixefat@dot-mail.top";
            string suaSenha = "123";
            string seuNome = "Bruno";

            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(seuEmail, seuNome);
            message.To.Add(new MailAddress(emailEnviarPara));
            message.Subject = "Aprovação de Cadastro";
            message.Body = "Sua solicitação de aluguel de vaga de garagem foi aprovada!";
            using (var client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
            {
                client.Credentials = new System.Net.NetworkCredential(seuEmail, suaSenha);
                client.EnableSsl = true;

                try
                {
                    client.Send(message);
                    return "Email enviado!";
                }
                catch (Exception ex)
                {
                    return "Erro ao enviar email: " + ex.Message;
                }
            }
        }

    }
}