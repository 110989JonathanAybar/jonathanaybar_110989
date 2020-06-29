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
        private int idTipoDocumento;
        [Required]
        private string nroDocumento;
        private int idDeporte;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdTipoDocumento { get => idTipoDocumento; set => idTipoDocumento = value; }
        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public int IdDeporte { get => idDeporte; set => idDeporte = value; }
    }
}