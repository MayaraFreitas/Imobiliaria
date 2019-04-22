using System;

namespace Imobiliaria.Service.VOs
{
    public class UserVO
    {
        public int pkUsuario { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public String cargo { get; set; }
        public String telefone { get; set; }
        public bool ativo { get; set; }
        public string email { get; set; }
        public bool sexo { get; set; }
        public DateTime nascimento { get; set; }
        public string senha { get; set; }
        public String celular { get; set; }
        public Boolean whatsapp { get; set; }

        public string Validar()
        {
            // adicionar logica de validacao

            return null;
        }
    }
}
