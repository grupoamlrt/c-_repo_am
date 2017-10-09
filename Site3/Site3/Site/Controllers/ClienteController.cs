using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;

namespace Site.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ClienteModel c)
        {
            Repositorio.Instance().IncluirFuncionario(c);

            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            var clientes = Repositorio.Instance().ListarFuncionarios();
            return View(clientes);
        }

        public ActionResult Excluir(int id)
        {
            Repositorio.Instance().ExcluirFuncionario(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            var cliente = Repositorio.Instance().ListarFuncionario(id);

            return View("Cadastrar", cliente);
        }

        [HttpPost]
        public ActionResult Editar(ClienteModel c)
        {
            Repositorio.Instance().AlterarFuncionario(c);

            return RedirectToAction("Listar");
        }
    }
}