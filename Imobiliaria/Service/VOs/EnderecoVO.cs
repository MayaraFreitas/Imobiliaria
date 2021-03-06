﻿using System;

namespace Imobiliaria.Service.VOs
{
    public class EnderecoVO
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }

        public UserVO Usuario { get; set; }
        public ClienteVO Cliente { get; set; }
        public ImovelVO Imovel { get; set; }
        public EmpresaVO Empresa { get; set; }
    }
}
