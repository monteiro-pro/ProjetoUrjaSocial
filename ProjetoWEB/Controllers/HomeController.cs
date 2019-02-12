using ProjetoWEB.Controllers.Fachada;
using ProjetoWEB.Models.Entidade;
using ProjetoWEB.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

                entidade.Nome_Cliente = model.Nome;
                entidade.CPF_Cliente = model.CPF;
                entidade.Idade_Cliente = model.Idade;
                entidade.Endereco_Cliente = model.Endereco;

                fachada.InsertCliente(entidade);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Erro ao tentar cadastrar, verifique se os campos foram preenchidos corretamente.");
            return View(model);
        }
    }
}