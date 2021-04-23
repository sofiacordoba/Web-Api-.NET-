using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWMedicos.Data;
using SWMedicos.Models;

namespace SWMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly MedicoContext _context;
        public MedicoController(MedicoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Medico> Get()
        {

            return _context.Medico.ToList();
        }


        [HttpGet("{especialidad}")]
        public ActionResult<Medico> Get(string especialidad)
        {
            var medico = _context.Medico.FirstOrDefault(x => x.Especialidad == especialidad);
            if (medico == null)
            {
                return NotFound();
            }
            return medico;
        }

        [HttpGet("{especialidad}/{ciudad}")]
        //customer/GetByCity/Berlin
        public IEnumerable<Medico> GetByEspecialidadCiudad(string especialidad, string ciudad)
        {
            List<Medico> medicos = (from m in _context.Medico
                                    where m.Ciudad == ciudad && m.Especialidad == especialidad
                                    select m).ToList();

            if (medicos == null)
            {
                NotFound();
            }
            return medicos;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Medico medico)
        {
            _context.Medico.Add(medico);
            _context.SaveChanges();   

            return new CreatedAtRouteResult("ObtenerMedico", new { id = medico.Id, medico });
        }

    }
}
