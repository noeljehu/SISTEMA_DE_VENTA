using Microsoft.EntityFrameworkCore;
using Models;

namespace BLL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ubigeo> Ubigeos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<CategoriaProducto> CategoriasProducto { get; set; }
        public DbSet<Compra> Compras { get; set; } 
        public DbSet<DetalleCompra> DetallesCompra { get; set; } 




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Ubigeo)
                .WithMany(u => u.Personas)
                .HasForeignKey(p => p.IdUbigeo)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Persona)
                .WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(c => c.IdPersona)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Trabajador>()
                .HasOne(t => t.Persona)
                .WithOne(p => p.Trabajador)
                .HasForeignKey<Trabajador>(t => t.IdPersona)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Trabajador)
                .WithOne(t => t.Usuario)
                .HasForeignKey<Usuario>(u => u.IdTrabajador)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.CategoriaProducto)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.IdCategoria)
                .OnDelete(DeleteBehavior.Restrict);

            // Nueva relación entre Compra y Proveedor
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Proveedor)
                .WithMany(p => p.Compras) // Debe coincidir con el nombre de la propiedad en Proveedor
                .HasForeignKey(c => c.IdProveedor)
                .OnDelete(DeleteBehavior.Restrict);


            // Relación entre Compra y DetalleCompra
            modelBuilder.Entity<DetalleCompra>()
                .HasOne(d => d.Compra)
                .WithMany(c => c.Detalles)
                .HasForeignKey(d => d.IdCompra)
                .OnDelete(DeleteBehavior.Cascade);

            // Relación entre DetalleCompra y Producto
            modelBuilder.Entity<DetalleCompra>()
                .HasOne(d => d.Producto)
                .WithMany(p => p.DetallesCompra)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
