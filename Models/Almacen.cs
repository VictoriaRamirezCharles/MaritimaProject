using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaritimaProject.Models
{
    public class Almacen: ObjetoAlmacenBase
    {
        [Required(ErrorMessage= "El nombre del Almacen es requerido")]
        public int Capacidad { get; set; }

        public string Ubicacion { get; set; }


        public List<Producto> Productos { get; set; }

    
        public Almacen()
        {

        }
         public Almacen(string nombre, string ubicacion) => (Nombre, Ubicacion) = (nombre, ubicacion);

        public Almacen(string nombre, string ubicacion,
                       
                       int capacidad = 0) : base()
        {
            (Nombre, Ubicacion) = (nombre, ubicacion);
            Capacidad = capacidad;
            
        }

       
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Capacidad: {Capacidad} {System.Environment.NewLine} Ubicacion: {Ubicacion}";
        }
    }
}
