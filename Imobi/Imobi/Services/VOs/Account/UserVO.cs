namespace Imobi.Services.VOs.Usuario
{
    public class UserVO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte Cargo { get; set; }
        public string Senha { get; set; }
        public string Documento { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Whats { get; set; }
        public string Email { get; set; }

        public string Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                return "ERRO";
            }

            return null;
        }

    }
}
