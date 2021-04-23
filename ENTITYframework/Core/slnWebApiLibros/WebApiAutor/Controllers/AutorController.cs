using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutor.Data;
using WebApiAutor.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApiAutor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly BaseAutorContext _context;

        public AutorController(BaseAutorContext context)
        {
            _context = context;
        }

        //api/autor
        [HttpGet]
        public IEnumerable<Autor> Get()   // AGREGO EL METODO GET
        {

            return _context.Autores.ToList();
        }

        //api/autor/ 2 (codigo del autor)
        [HttpGet("{id}")]
        public ActionResult<Autor> Get(int id)  // ActionResult es una var para devolver todo tipo de resultados
        {
            var autor = _context.Autores.FirstOrDefault(x => x.AutorId == id);
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }


        // CREAR UN NUEVO AUTOR
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();    //conecta a la DB-insert a la tabla autor-desconecta

            return new CreatedAtRouteResult("ObtenerAutor", new { id = autor.AutorId, autor });
            // metodo donde paso la ruta y el id del autor insertado
        }


        // MODIFICAR EL AUTOR
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {
            if (id != autor.AutorId)
            {
                BadRequest();
            }
            _context.Entry(autor).State = EntityState.Modified;
            _context.SaveChanges();        //envia el update de la tabla a la base de datos
            return Ok();

        }

        // ELIMINAR EL AUTOR
        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            var autor = _context.Autores.Find(id);

            if (autor == null)
            {
                return NotFound();
            }


            _context.Autores.Remove(autor);
            _context.SaveChanges();//enviar el delete from a la base de datos
            return autor;

        }
    }
}
