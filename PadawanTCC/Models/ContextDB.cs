using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PadawanTCC.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<Cor> cores { get; set; }
        public DbSet<TipoVeiculo> tipoVeiculos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Locacao> locacoes { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<TermoUso> termosDeUso { get; set; }
    }
}