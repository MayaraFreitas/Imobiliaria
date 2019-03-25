using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imobi.Models.ViewModels.Usuario
{
    public class ViewUserLoginVM
    {
        [Required(ErrorMessage = "O email do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Senha { get; set; }
    }
}

