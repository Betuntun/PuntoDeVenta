using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoDeVenta.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {      

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductoVenta>().HasKey(x => new { x.ProductoId, x.VentaId });

            builder.Entity<Categoria>()
                .HasOne(b => b.ApplicationUser)
                .WithMany(a => a.Categorias).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Producto>()
             .HasOne(b => b.ApplicationUser)
             .WithMany(a => a.Productos).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Venta>()
             .HasOne(b => b.ApplicationUser)
             .WithMany(a => a.Ventas).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Cliente>()
             .HasOne(b => b.ApplicationUser)
             .WithMany(a => a.Clientes).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
          
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVenta> ProductosVentas { get; set; }


    }
}
