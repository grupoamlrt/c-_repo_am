using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;

namespace Site.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ContatoModel c)
        {
            RepositorioContato.Instance().CadastrarContato(c);

            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            var clientes = RepositorioContato.Instance().ListarContatos();
            return View(clientes);
        }

        public ActionResult Excluir(int id)
        {
            RepositorioContato.Instance().ExcluirContato(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            var cliente = RepositorioContato.Instance().ListarContatos(id);

            return View("Cadastrar", cliente);
        }

        [HttpPost]
        public ActionResult Editar(ContatoModel n)
        {
            RepositorioContato.Instance().AlterarContato(n);

            return RedirectToAction("Listar");
        }
    }
}