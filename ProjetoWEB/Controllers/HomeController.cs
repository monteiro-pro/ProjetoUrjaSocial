using ProjetoWEB.Controllers.Fachada;
using ProjetoWEB.Models.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ProjetoWEB.Models.ViewModels.HomeViewModels;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Manage/TelaInicial
        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Manage/Cadastro
        [HttpPost]
        public ActionResult Cadastro(CadastroViewModels model)
        {
            if (ModelState.IsValid)
            {
                Fachada fachada = new Fachada();
                Cliente entidade = new Cliente();

                entidade.Nome_Cliente = model.Nome_Cliente;
                entidade.CPF_Cliente = model.CPF_Cliente;
                entidade.Idade_Cliente = model.Idade_Cliente;
                entidade.Endereco_Cliente = model.Endereco_Cliente;

                fachada.InsertCliente(entidade);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Erro ao tentar cadastrar, verifique se os campos foram preenchidos corretamente.");
            return View(model);
        }
    }
}