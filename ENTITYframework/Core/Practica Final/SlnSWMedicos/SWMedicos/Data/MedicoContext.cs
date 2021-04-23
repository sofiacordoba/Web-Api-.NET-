using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWMedicos.Models;

namespace SWMedicos.Data
{
    public class MedicoContext : DbContext
    {
        public MedicoContext(DbContextOptions<MedicoContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medico { get; set; }
    }
}
