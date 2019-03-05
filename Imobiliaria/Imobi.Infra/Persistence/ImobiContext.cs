using Imobi.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Imobi.Infra.Persistence
{
    public class ImobiContext : DbContext
    {
        #region Construtor

        public ImobiContext() : base("ImobiConnectionString")    //base recebe o nome de uma config no appconfig da aplicação
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false; //Quando colocar . (ponto) tras o objeto filho. - Verificar necessinade
        }

        #endregion

        public IDbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Seta o Schema default
            //modelBuilder.HasDefaultSchema("Apoio");

            // Remove a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            // Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            // Mapeia as entidades - Será substituido pelo uso do assembly
            //modelBuilder.Conventions.Add(new UsuarioMap());

            // Adiciona entidades mapeadas - Automaticamente via NameSpace
            modelBuilder.Conventions.AddFromAssembly(typeof(ImobiContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
