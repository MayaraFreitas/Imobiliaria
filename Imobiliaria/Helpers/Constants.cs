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

        public static class SimNao
        {
            public static byte Sim = 1;
            public static byte Nao = 2;
        }

        public static class Cargo
        {
            public static byte Administrativo = 1;
            public static byte Vistoriador = 2;
            public static byte Cliente = 3;
        }

        public static class StatusVistoria
        {
            public static byte EmVistoria = 1;
            public static byte Cancelado = 2;
            public static byte Vistoriado = 3;
        }

        public static class Sexo
        {
            public static byte Feminino = 1;
            public static byte Masculino = 2;
        }

        public static class TemWhatsapp
        {
            public static byte Sim = 1;
            public static byte Nao = 2;
        }
    }
}
