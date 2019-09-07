using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace MaritimaProject.Models
{
    public class AlmacenContext : DbContext
    {
        public DbSet<Almacen> Almacene { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
      

        public AlmacenContext(DbContextOptions<AlmacenContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var almacen = new Almacen();
            almacen.Id=Guid.NewGuid().ToString();
            almacen.Nombre="Maritima I";
            almacen.Capacidad=600;
            almacen.Ubicacion="Haina, San Cristobal";

            var productos = CargarProductos(almacen);

            modelBuilder.Entity<Almacen>().HasData(almacen);
            modelBuilder.Entity<Producto>().HasData(productos.ToArray());
            
          
        }
         private static List<Producto> CargarProductos(Almacen almacen)
        {
            return new List<Producto>(){
                        new Producto() {
                            Id = Guid.NewGuid().ToString(),
                            AlmacenId = almacen.Id,
                            Nombre = "Cepillo Dental",
                            Categoria = Categoria.Limpieza,
                            Precio=150,
                            Descripcion="Buena Calidad"
                             },
                        new Producto() {Id = Guid.NewGuid().ToString(), AlmacenId = almacen.Id, Nombre = "Pan Sobao", Categoria = Categoria.Panaderia, Precio=55,Descripcion="Receta Italiana"},
                        
            };
        }
    }
}