using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ISoft2_BodegaPineda.Models
{
    public class Contexto:DbContext
    {
        //Clase donde se instanciaran los objetos de la base de datos.
        public DbSet<Proveedores> Proveedores { get; set; }

    }
}