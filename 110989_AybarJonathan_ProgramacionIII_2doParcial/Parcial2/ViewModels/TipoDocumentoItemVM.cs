using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2.ViewModels
{
    public class TipoDocumentoItemVM
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}