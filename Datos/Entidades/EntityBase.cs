using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class EntityBase
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
