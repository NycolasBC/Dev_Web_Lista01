﻿using System.ComponentModel.DataAnnotations;
using WebApplication01.Models.Validations;
using WebApplicationList01.Models.Validations;

namespace WebApplicationList01.Models.Request
{
    public class NovoAlunoViewModel
    {
        [Required(ErrorMessage = "O RA é obrigatório!")]
        [RaValidation("RA", 6)]
        public string RA { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório!")]
        [CpfValidation]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Este campo deve ser ativo.")]
        public bool Ativo { get; set; }
    }
}
