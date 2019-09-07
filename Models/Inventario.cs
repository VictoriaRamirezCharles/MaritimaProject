using System.ComponentModel.DataAnnotations;

namespace MaritimaProject.Models
{
    public class Inventario:ObjetoAlmacenBase
    {
        public Producto Producto { get; set; }
        public string ProductoId { get; set; }

          [Required(ErrorMessage= "La Existencia es requerida")]
        public float Stock { get; set; }

        public override string ToString()
        {
            return $"{Stock}, {Producto.Nombre}";
        }
    }
}