using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Imobiliaria.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imobiliaria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Solicitacao>    Solicitacao { get; set; }
        public DbSet<Cliente>        Cliente { get; set; }
        public DbSet<Comodo>         Comodo { get; set; }
        public DbSet<Empresa>        Empresa { get; set; }
        public DbSet<Imovel>         Imovel { get; set; }
        public DbSet<Endereco>       Endereco { get; set; }
        public DbSet<Nota>           Nota { get; set; }
        public DbSet<Vistoria>       Vistoria { get; set; }
        public DbSet<Medicao>        Medicao { get; set; }
        public DbSet<LogSolicitacao> LogSolicitacao { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Solicitacao>()
                .Property(p => p.Id).ValueGeneratedOnAdd();// (DatabaseGeneratedOption.Identity);

        }
        */
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solicitacao>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }*/
    }
}
