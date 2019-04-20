using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiCore.Data.Entities
{
    public class User
    {
        int pkUsuario;
        string nome;
        string documento;
        String cargo;
        String telefone;
        bool ativo;
        string email;
        bool sexo;
        DateTime nascimento;
        string senha;
        String celular;
        Boolean whatsapp;

        Endereco endereco;

        List<Empresa> empresas = new List<Empresa>();
        List<Solicitacao> solitacoes = new List<Solicitacao>();


    }
}
