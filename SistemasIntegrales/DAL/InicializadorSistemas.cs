using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SistemasIntegrales.Models;

namespace SistemasIntegrales.DAL
{
    public class InicializadorSistemas : System.Data.Entity. DropCreateDatabaseIfModelChanges<TiendaContext>
    {
        protected override void Seed(TiendaContext context)
        {


            var clientes = new List<Cliente>
            {
            new Cliente{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Cliente{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Cliente{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Cliente{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Cliente{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
            var productos = new List<Producto>
            {
            new Producto{ProductoID=1050,Nombre="Alimentos",Costo=3,},
            new Producto{ProductoID=4022,Nombre="Frutas",Costo=3,},
            new Producto{ProductoID=4041,Nombre="Verduras",Costo=3,},
            new Producto{ProductoID=1045,Nombre="Carnes",Costo=4,},
            new Producto{ProductoID=3141,Nombre="Electronicos",Costo=7,},
            new Producto{ProductoID=2021,Nombre="Despensa",Costo=3,},
            new Producto{ProductoID=2042,Nombre="Revistas",Costo=4,}
            };
            productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();
            var registros = new List<Registro>
            {
            new Registro{ClienteID=1,ProductoID=1050,Prioridad=Prioridad.A},
            new Registro{ClienteID=1,ProductoID=4022,Prioridad=Prioridad.C},
            new Registro{ClienteID=1,ProductoID=4041,Prioridad=Prioridad.B},
            new Registro{ClienteID=2,ProductoID=1045,Prioridad=Prioridad.B},
            new Registro{ClienteID=2,ProductoID=3141,Prioridad=Prioridad.F},
            new Registro{ClienteID=2,ProductoID=2021,Prioridad=Prioridad.F},
            new Registro{ClienteID=3,ProductoID=1050},
            new Registro{ClienteID=4,ProductoID=1050,},
            new Registro{ClienteID=4,ProductoID=4022,Prioridad=Prioridad.F},
            new Registro{ClienteID=5,ProductoID=4041,Prioridad=Prioridad.C},
            new Registro{ClienteID=6,ProductoID=1045},
            new Registro{ClienteID=7,ProductoID=3141,Prioridad=Prioridad.A},
            };
            registros.ForEach(s => context.Registros.Add(s));
            context.SaveChanges();
        }
    }
}