using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemasIntegrales.Models;

namespace SistemasIntegrales.Models
{
    public enum Prioridad
    {
        A, B, C, D, E, F
    }
    public class Registro
    {
        public int RegistroID { get; set; }
        public int ProductoID { get; set; }
        public int ClienteID { get; set; }
        public Prioridad? Prioridad { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}