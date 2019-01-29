using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Models.ViewModels
{
    public class HomeViewModels
    {
        public class CadastroViewModels
        {
            [Required]
            [Display(Name = "Nome")]
            public string Nome_Cliente { get; set; }

            [Required]
            [Display(Name = "CPF")]
            public string CPF_Cliente { get; set; }

            [Required]
            [Display(Name = "Idade")]
            public int Idade_Cliente { get; set; }

            [Required]
            [Display(Name = "Endereco")]
            public string Endereco_Cliente { get; set; }
        }
    }
}