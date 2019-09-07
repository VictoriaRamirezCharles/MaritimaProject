using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaritimaProject.Models
{
    public class Producto: ObjetoAlmacenBase
    {
      
        
        public Categoria Categoria { get; set; }
          [Required(ErrorMessage= "Debe Colocar un Precio")]
        public double Precio { get; set; }

        public string Descripcion { get; set; }
        public Almacen Almacen { get; set; }
        public string AlmacenId { get; set; }
    }
}