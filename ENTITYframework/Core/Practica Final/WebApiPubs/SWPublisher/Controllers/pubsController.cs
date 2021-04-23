using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SWPublisher.Models;
using SWPublisher.Data;
using Microsoft.EntityFrameworkCore;


namespace SWPublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pubsController : ControllerBase
    {

        private readonly pubsContext _context;
        public pubsController(pubsContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Publishers> Get()
        {
            return _context.Publishers.ToList();
        }


        [HttpGet("{country}")]
        public ActionResult<List<Publishers>> GetPublishers(string country)
        {
            return _context.Publishers.Where(x => x.Country == country).ToList();
        }


        [HttpGet("{pais}/{ciudad}")]
        public IEnumerable<Publishers> GetByPaisCiudad(string pais, string ciudad)
        {
            var publishers = _context.Publishers.Where(x => x.Country == pais && x.City == ciudad).ToList();
            if (publishers == null)
            {
                NotFound();
            }
            return (IEnumerable<Publishers>)publishers;
        }


        [HttpPost]
        public ActionResult Post([FromBody] Publishers publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerPublisher", new { Id = publisher.PubId }, publisher);
        }
    }
}
