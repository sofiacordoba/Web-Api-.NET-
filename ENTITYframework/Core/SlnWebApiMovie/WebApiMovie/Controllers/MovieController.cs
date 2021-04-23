using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiMovie.Data;
using WebApiMovie.Models;

namespace WebApiMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;
        public MovieController(MovieContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Movie> Get()
        {

            return _context.Movies.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)  // ActionResult es una var para devolver todo tipo de resultados
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpGet("{year}")]
        //[Route("api/movies/{year}")]
        public ActionResult<Movie> GetByYear(DateTime year)  // ActionResult es una var para devolver todo tipo de resultados
        {
            var movie = _context.Movies.FirstOrDefault(x => x.ReleaseYear == year);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
    }
}
