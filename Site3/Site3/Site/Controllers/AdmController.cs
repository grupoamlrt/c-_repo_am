using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;

namespace Site.Controllers
{
    public class AdmController : Controller
    {
        // GET: Adm
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Cadastrar()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Cadastrar(AdmModel a)
        //{
        //    Repositorio.Instance().IncluirFuncionario(a);

        //    return RedirectToAction("Listar");
        //}
        //public ActionResult Listar()
        //{
        //    var clientes = Repositorio.Instance().ListarFuncionarios();
        //    return View(clientes);
        //}

        //public ActionResult Excluir(int id)
        //{
        //    Repositorio.Instance().ExcluirFuncionario(id);
        //    return RedirectToAction("Listar");
        //}

        //public ActionResult Editar(int id)
        //{
        //    var cliente = Repositorio.Instance().ListarFuncionario(id);

        //    return View("Cadastrar", cliente);
        //}

        //[HttpPost]
        //public ActionResult Editar(AdmModel a)
        //{
        //    Repositorio.Instance().AlterarFuncionario(a);

        //    return RedirectToAction("Listar");
        //}
    }
}