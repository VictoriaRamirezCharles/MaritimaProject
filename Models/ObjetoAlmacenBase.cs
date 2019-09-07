namespace MaritimaProject.Models
{
    public abstract class ObjetoAlmacenBase
    {
         public string Id { get; set; }
         public virtual string Nombre { get; set; }

        public ObjetoAlmacenBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
        
    }
