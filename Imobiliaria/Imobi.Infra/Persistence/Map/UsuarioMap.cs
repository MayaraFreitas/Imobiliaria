using Imobi.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Imobi.Infra.Persistence.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        #region Construtor

        public UsuarioMap()
        {
            ToTable("Usuario");
            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Usuario", new IndexAnnotation(new IndexAttribute("UK_USUARIO_EMAIL") { IsUnique = true })).HasColumnName("Email_Endereco");
            Property(p => p.Nome.PrimeiroNome).HasMaxLength(50).IsRequired().HasColumnName("Nome_PrimeiroNome");
            Property(p => p.Nome.SobreNome).HasMaxLength(50).IsRequired().HasColumnName("Nome_SobreNome");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();
            Property(p => p.Apelido);
        }

        #endregion
    }
}
