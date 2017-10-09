using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;

namespace Site.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(NoticiasModel n)
        {
            RepositorioNoticias.Instance().IncluirNoticia(n);

            return RedirectToAction("ListarNoticia");
        }
        public ActionResult Listar()
        {
            var clientes = RepositorioNoticias.Instance().ListarNoticias();
            return View(clientes);
        }

        public ActionResult Excluir(int id)
        {
            RepositorioNoticias.Instance().ExcluirNoticia(id);
            return RedirectToAction("ListarNoticia");
        }

        public ActionResult Editar(int id)
        {
            var cliente = RepositorioNoticias.Instance().ListarNoticia(id);

            return View("CadastrarNoticia", cliente);
        }

        [HttpPost]
        public ActionResult Editar(NoticiasModel n)
        {
            RepositorioNoticias.Instance().AlterarNoticia(n);

            return RedirectToAction("ListarNoticia");
        }
    }
}