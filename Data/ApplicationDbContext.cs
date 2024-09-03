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

        protected override void OnModelCreating(ModelBuilder builder)
        {   
            base.OnModelCreating( builder );

            builder.Entity<Propietario>( propietario => {
                propietario.ToTable("Propietarios");
                propietario.HasKey( p => p.Id );
                propietario.Property( p => p.Id ).ValueGeneratedOnAdd();
                propietario.Property( p => p.Nombre ).HasMaxLength(100).IsRequired();
                propietario.Property( p => p.Apellido ).HasMaxLength(100).IsRequired();
                propietario.Property( p => p.Direccion ).HasMaxLength(100).IsRequired();
                propietario.Property( p => p.Telefono ).HasMaxLength(10).IsRequired();
                propietario.Property( p => p.Correo ).HasMaxLength(125).IsRequired();
            });

            builder.Entity<Vehiculos>( vehiculo => {
                vehiculo.ToTable("Vehiculos");

                vehiculo.HasKey( v => v.Id );
                vehiculo.Property( v => v.Id ).ValueGeneratedOnAdd();
                vehiculo.Property( v => v.Marca ).HasMaxLength(100).IsRequired();
                vehiculo.Property( v => v.Modelo ).HasMaxLength(100).IsRequired();
                vehiculo.Property( v => v.Color ).HasMaxLength(100).IsRequired();
                vehiculo.Property( v => v.Año ).HasMaxLength(4).IsRequired();
                vehiculo.Property( v => v.TipoVehiculo ).HasMaxLength(50).IsRequired();
                vehiculo.Property( v => v.NumeroChasis ).HasMaxLength(25).IsRequired();

                vehiculo.HasOne( v => v.Propietario )
                    .WithMany( p => p.Vehiculos )
                        .HasForeignKey( v => v.PropietarioId )
                            .OnDelete( DeleteBehavior.Restrict );

                
            });
        }
    }
