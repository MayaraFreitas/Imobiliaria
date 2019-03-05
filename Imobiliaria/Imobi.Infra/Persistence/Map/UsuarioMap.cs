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
            ToTable("TB_USUARIO");
            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("CD_USUARIO", new IndexAnnotation(new IndexAttribute("UK_USUARIO_EMAIL") { IsUnique = true })).HasColumnName("DC_EMAIL");
            Property(p => p.Nome.PrimeiroNome).HasMaxLength(50).IsRequired().HasColumnName("DC_PRIMEIRO_NOME");
            Property(p => p.Nome.SobreNome).HasMaxLength(50).IsRequired().HasColumnName("DC_SOBRENOME");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();
        }

        #endregion
    }
}
