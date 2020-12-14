using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemasIntegrales.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public int Costo { get; set; }

        public virtual ICollection<Registro> Enrollments { get; set; }
    }
}