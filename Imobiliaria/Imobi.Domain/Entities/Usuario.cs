using Imobi.Domain.VOs;
using System;

namespace Imobi.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte Status { get; set; }
    }
}
