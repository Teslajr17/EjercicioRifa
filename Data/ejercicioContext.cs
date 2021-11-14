using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ejercicio.Models;

namespace ejercicio.Data
{
    public class ejercicioContext : DbContext
    {
        public ejercicioContext (DbContextOptions<ejercicioContext> options)
            : base(options)
        {
        }

        public DbSet<ejercicio.Models.Class> Class { get; set; }
    }
}
