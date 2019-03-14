using Imobi.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace Imobi.Domain.VOs
{
    public class Nome : Notifiable
    {
        protected Nome()
        {

        }

        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            // Validar
            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(u => u.PrimeiroNome, 1, 10, Message.Generico_MinMax_0X_A.ToFormat(Message.Usuario_Primeiro_Nome, 1, 10))
                .IfNullOrInvalidLength(u => u.SobreNome, 1, 10, Message.Generico_MinMax_0X_A.ToFormat(Message.Usuario_SobreNome_Nome, 1, 10));
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }

        public override string ToString()
        {
            return PrimeiroNome + " " + SobreNome;
        }
    }
}
