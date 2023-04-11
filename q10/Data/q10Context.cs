using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using q10.Models;

namespace q10.Data
{
    public class q10Context : DbContext
    {
        public q10Context (DbContextOptions<q10Context> options)
            : base(options)
        {
        }

        public DbSet<q10.Models.Tarea> Tarea { get; set; } = default!;
    }
}
