using Imobi.Domain.Resources;
using prmToolkit.NotificationPattern;

namespace Imobi.Domain.VOs
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(e => e.Endereco, string.Format(Message.Generico_Invalido_0X, Message.Generico_Titulo_Email));
        }

        public string Endereco { get; set; }
    }
}
