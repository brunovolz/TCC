using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PadawanProject.Models
{
    public class ContextDB : DbContext
    {
        [Key]
        public DbSet<Marca>Marcas { get; set; }
        public DbSet<Modelo>Modelos { get; set; }
        public DbSet<Cor>Cores { get; set; }
        public DbSet<TipoVeiculo>TipoVeiculos { get; set; }
        public DbSet<Cliente>Clientes { get; set; }
        public DbSet<Usuario>Usuarios { get; set; }
        public DbSet<Locacao>Locacoes { get; set; }
        public DbSet<Periodo>Periodos { get; set; }
        public DbSet<TermoUso>TermosUso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}