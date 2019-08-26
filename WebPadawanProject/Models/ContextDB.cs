using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebPadawanProject.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Automovel>automovels { get; set; }
        public DbSet<Motocicleta>motocicletas { get; set; }

    }
}