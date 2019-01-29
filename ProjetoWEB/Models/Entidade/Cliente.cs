using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Models.Entidade
{
    public class Cliente
    {
        public string Nome_Cliente { get; set; }

        public string CPF_Cliente { get; set; }

        public int Idade_Cliente { get; set; }

        public string Endereco_Cliente { get; set; }
    }
}