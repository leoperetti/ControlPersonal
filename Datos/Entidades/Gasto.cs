using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    [Table("Gastos")]
    public class Gasto : EntityBase
    {
        [Column("cantidadDinero")]
        public int CantidadDinero { get; set; }

        [Column("cantidadProductos")]
        public int CantidadProductos { get; set; }

        [Column("fechaGasto")]
        public DateTime FechaGasto { get; set; }
    }
}
