using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Models;

namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {  

            private readonly PubsContext _context;

            public AuthorController(PubsContext context)
            {
                _context = context;
            }
            [HttpGet]
            public IEnumerable<Authors> Get()
            {
                return _context.Authors.ToList();
            }

            [HttpGet("{id}")]
            public ActionResult<Authors> GetAuthors(string id)
            {
                return _context.Authors.Find(id);
            }
    }
}
