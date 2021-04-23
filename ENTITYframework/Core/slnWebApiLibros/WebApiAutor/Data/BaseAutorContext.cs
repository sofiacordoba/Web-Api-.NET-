using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // agregar
using WebApiAutor.Models; // agregar


namespace WebApiAutor.Data
{
    public class BaseAutorContext: DbContext
    {
        public BaseAutorContext(DbContextOptions<BaseAutorContext> options)
       : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
