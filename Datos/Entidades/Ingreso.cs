using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    [Table("Ingresos")]
    public class Ingreso : EntityBase
    {
        [Column("ingreso")]
        public int IngresoValor { get; set; }

        [Column("fechaIngreso")]
        public DateTime FechaIngreso { get; set; }
    }
}
