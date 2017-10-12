using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Site.Models.Context
{
    public class ClassContext : DbContext
    {
        public ClassContext() : base("OracleDbContext") { }

        public DbSet<NoticiasModel> Noticia { get; set; }
        public DbSet<AdmModel> Administrador { get; set; }
        public DbSet<ContatoModel> Contato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RM71805");
            base.OnModelCreating(modelBuilder);
        }
    }
}