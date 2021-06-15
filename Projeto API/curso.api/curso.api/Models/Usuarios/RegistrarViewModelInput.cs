using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class RegistrarViewModelInput
    {
        [Required(ErrorMessage = "O E-mail é obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        public string Senha { get; set; }
    }
}
