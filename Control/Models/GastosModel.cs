using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace ControlPrecios.Models
{
    public class GastosModel
    {
        public Comercios Comercio { get; set; }

        [DisplayName("Id")]
        public int? Id { get; set; }

        [DisplayName("Cantidad gastada")]
        public int Dinero { get; set; }

        [DisplayName("Cantidad de Productos")]
        public int Productos { get; set; }
        
        [DisplayName("Fecha")]
        public string Fecha { get; set; }

        [DisplayName("Tipo de Comercio")]
        public int IdTipoComercio { get; set; }
        public IEnumerable<SelectListItem> Comercios { get; set; }

    }
}