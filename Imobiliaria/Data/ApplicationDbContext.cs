using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Imobiliaria.Data.Entities;
using Imobiliaria.Helpers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imobiliaria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // Usuario
        public DbSet<ViewUsuario> ViewUsuario { get; set; }

        // Solicitacao
        public DbSet<Solicitacao> Solicitacao { get; set; }
        public DbSet<ViewSolicitacao> ViewSolicitacao { get; set; }
        public DbSet<LogSolicitacao> LogSolicitacao { get; set; }

        // Vistoria
        public DbSet<Vistoria> Vistoria { get; set; }
        public DbSet<Comodo> Comodo { get; set; }
        public DbSet<ViewComodo> ViewComodo { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<ViewNota> ViewNota { get; set; }
        public DbSet<Medicao> Medicao { get; set; }

        // Outros
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        
        #region override
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Endereco>()
            .HasData(
                new Endereco { Id = 1, Estado = "PA", Cidade = "Belém", Cep = "66020-690", Bairro = "Cidade Velha", Rua = "Passagem Maria Luísa", Numero= "544", Ativo = true}
        );

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Solicitacao>()
                .Property(p => p.Id).ValueGeneratedOnAdd();// (DatabaseGeneratedOption.Identity);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solicitacao>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }*/

        #endregion
    }
}
