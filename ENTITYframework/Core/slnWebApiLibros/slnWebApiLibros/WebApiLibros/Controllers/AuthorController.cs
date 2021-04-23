﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApiLibros.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
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
