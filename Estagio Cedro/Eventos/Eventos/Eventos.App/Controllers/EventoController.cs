using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.AcessoADados.ModelView;
using Eventos.RegrasDeNegocios;

namespace Eventos.App.Controllers
{
    //[Produces("application/json")]
    [Route("api/Evento")]
    public class EventoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] EventoModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Inserir(eventoModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Serie/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] EventoModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Atualizar(id, eventoModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Serie/5
        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {
            try
            {
                var eventoBll = new EventoBll();
                var evento = eventoBll.ObterPorId(id);
                return Json(evento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var eventoBll = new EventoBll();
                var listaDeEventos = eventoBll.obterTodos();
                return Json(listaDeEventos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
