using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Helpers
{
    public static class Constants
    {
        public static class StatusAtivo
        {
            public static byte Ativo = 1;
            public static byte Desativado = 0;
        }

        public static class StatusSolicitacao
        {
            public static byte Aguardando = 1;
            public static byte Cancelado = 2;
            public static byte Aceita = 3;
        }

        public static class StatusVistoria
        {
            public static byte EmVistoria = 1;
            public static byte Cancelado = 2;
            public static byte Vistoriado = 3;
        }
    }
}
