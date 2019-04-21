using System;

namespace Imobiliaria.Service.VOs
{
    public class VistoriaVO
    {
        public int pkVistoria { get; set; }
        public DateTime dataInicio { get; set; }
        public bool ativo { get; set; }
        public DateTime dataFim { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}
