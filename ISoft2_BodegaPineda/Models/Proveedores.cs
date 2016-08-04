using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISoft2_BodegaPineda.Models
{
    public class Proveedores
    {
        public int id { get; set; }
        public int? idProveedor { get; set; }   //puede ser nulo
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string rtn { get; set; }
        public string claveIhcafe { get; set; }
    }
}