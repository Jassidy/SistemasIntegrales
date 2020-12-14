using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SistemasIntegrales.Models;

namespace SistemasIntegrales.DAL
{
    public class TiendaContext : DbContext
    {
        public TiendaContext() : base("TiendaContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}