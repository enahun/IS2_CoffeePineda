//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationBodegaPineda.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistroPeso
    {
        public int idRegistroPeso { get; set; }
        public int idProducto { get; set; }
        public int idUser { get; set; }
        public int idProveedor { get; set; }
        public decimal peso { get; set; }
        public decimal descuento { get; set; }
        public int tara { get; set; }
        public decimal total { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        public virtual User User { get; set; }
    }
}
