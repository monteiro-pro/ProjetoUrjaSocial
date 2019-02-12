using ProjetoWEB.Controllers.Regra;
using ProjetoWEB.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Controllers.Fachada
{
    public class Fachada
    {
        private ClienteRegra Cliente;

        public Fachada()
        {
            Cliente = new ClienteRegra();
        }

        #region Cliente
        public void InsertCliente(Cliente cliente)
        {
            Cliente.Insert(cliente);
        }

        public void RemoveCliente(Cliente cliente)
        {
            Cliente.Remove(cliente);
        }

        //public void UpdateCliente(Cliente cliente)
        //{
        //    Cliente.Update(cliente);
        //}

        //public Cliente SelectCliente(int id)
        //{
        //    return Cliente.Select(id);
        //}

        public IList<Cliente> ListCliente()
        {
            return Cliente.List();
        }
        #endregion
    }
}