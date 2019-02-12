using ProjetoWEB.Models.Dados.Context;
using ProjetoWEB.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Controllers.Regra
{
    public class ClienteRegra
    {
        public void Insert(Cliente entidade)
        {
            VerificarDuplicidade(entidade);

            Validar(entidade);

            ClienteContext context = new ClienteContext();
            context.Cliente.Add(entidade);
            context.SaveChanges();
        }

        //public void Update(Cliente entidade)
        //{
        //    Validar(entidade);

        //    new ClienteContext().Cliente.up(entidade);
        //}

        public void Remove(Cliente entidade)
        {
            Validar(entidade);

            new ClienteContext().Cliente.Remove(entidade);
        }

        //public Cliente Select(int id)
        //{
        //    return new ClienteRepositorio().Select(id);
        //}

        public IList<Cliente> List()
        {
            return new ClienteContext().Cliente.ToList();
        }

        public void Validar(Cliente entidade)
        {
            if (entidade == null)
            {
                throw new Exception("Entidade nula!");
            }

            if (String.IsNullOrEmpty(entidade.Nome_Cliente))
            {
                throw new Exception("Nome não informado!");
            }

            if (String.IsNullOrEmpty(entidade.CPF_Cliente))
            {
                throw new Exception("CPF não informado!");
            }

            if (entidade.Idade_Cliente == 0)
            {
                throw new Exception("Idade não informada!");
            }

            if (String.IsNullOrEmpty(entidade.Endereco_Cliente))
            {
                throw new Exception("Endereço não informado!");
            }
        }

        private void VerificarDuplicidade(Cliente cliente)
        {

        }
    }
}