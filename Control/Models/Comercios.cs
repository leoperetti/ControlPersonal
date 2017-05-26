using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ControlPrecios.Models
{
    public class Comercios
    {
        [DisplayName("Id")]
        public int? IdTipoComercio { get; set; }

        [DisplayName("Tipo Comercio")]
        public string TipoComercio { get; set; }

        [DisplayName("Habilitado")]
        public bool Habilitado { get; set; }
    }
}