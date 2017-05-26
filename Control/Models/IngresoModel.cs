using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ControlPrecios.Models
{
    public class IngresoModel
    {
        [DisplayName("Id")]
        public int? Id { get; set; }

        [DisplayName("Sueldo")]
        public int Sueldo { get; set; }

        [DisplayName("Fecha Ingreso")]
        public DateTime? Fecha { get; set; }
        
    }
}