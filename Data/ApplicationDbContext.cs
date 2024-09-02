using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.Models;

namespace Taller.Data;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Propietario> Propietarios { get; set; }

        public DbSet<Vehiculos> Vehiculos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
