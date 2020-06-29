using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2.Models
{
    public class Socio
    {
        private int id;
        [Required]
        private string nombre;
        [Required]
        private string apellido;
        private string idTipoDocumento;
        private string nroDocumento;
        private string idDeporte;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string IdTipoDocumento { get => idTipoDocumento; set => idTipoDocumento = value; }
        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string IdDeporte { get => idDeporte; set => idDeporte = value; }
    }
}