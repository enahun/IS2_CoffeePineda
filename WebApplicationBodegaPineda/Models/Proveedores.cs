using System.Data.Entity;

namespace WebApplicationBodegaPineda.Models
{
    public class Proveedores
    {
        public int id { get; set; }
        public string nombreProveedor { get; set; }
        public string apellidoProveedor { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public int? rtnProveedor { get; set; }
        public string claveIhcafe { get; set; }
    }
  
}