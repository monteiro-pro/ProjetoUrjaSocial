using ProjetoWEB.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Models.Dados.Context
{
    public class ClienteContext : DbContext
    {

        public ClienteContext() : base("ClienteContext")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}