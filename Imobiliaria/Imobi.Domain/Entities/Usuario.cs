using Imobi.Domain.Extensions;
using Imobi.Domain.Resources;
using Imobi.Domain.VOs;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Imobi.Domain.Entities
{
    public class Usuario : Notifiable
    {
        #region Construtores

        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            // Validação
            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(u => u.Senha, 6, 10, Message.Generico_MinMax_0X_A.ToFormat(Message.Generico_Titulo_Senha,6,10));

        }

        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = 1; // ADICIONAR ENUM OU CLASSE DE CONSTANTS

            // Validação
            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(u => u.Senha, 6, 10, Message.Generico_MinMax_0X_A.ToFormat(Message.Generico_Titulo_Senha, 6, 15));

            if(IsValid())
            {
                // Criptografar
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);
        }

        #endregion

        #region Propriedades

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public string Apelido { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public byte Status { get; private set; }

        #endregion
    }
}
