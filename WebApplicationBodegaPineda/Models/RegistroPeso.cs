using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationBodegaPineda.Models
{
    public class RegistroPeso
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int idProveedor  { get; set; }
        public double peso { get; set; }
        public int descuento { get; set; }
        public int tara { get; set; }
        public double total { get; set; }
    }
}