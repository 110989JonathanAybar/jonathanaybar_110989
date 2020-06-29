using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Reporte
    {
        private string deporte;
        [Required]
        private int cantidadSocios;
        [Required]

        public string Deporte { get => deporte; set => deporte = value; }
        public int CantidadSocios { get => cantidadSocios; set => cantidadSocios = value; }
    }
}
