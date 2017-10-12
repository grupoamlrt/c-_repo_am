using Site.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class RepositorioAdm
    {
        private static RepositorioAdm _repositorio;

        private List<AdmModel> admin;

        private RepositorioAdm()
        {
            admin = new List<AdmModel>();
        }
        public static RepositorioAdm Instance()
        {
            if (_repositorio == null)
            {
                _repositorio = new RepositorioAdm();
            }
            return _repositorio;
        }

        public static AdmModel ProcurarPorId(string email, string senha)
        {
            using (var ctx = new ClassContext())
            {
                return ctx.Administrador.FirstOrDefault(user =>
                                                user.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase) &&
                                                user.Senha.Equals(senha, StringComparison.CurrentCultureIgnoreCase)
                                            );
            }

        }

        public static bool CadastrarAdm(AdmModel adm)
        {

            using (var ctx = new ClassContext())
            {

                List<AdmModel> admin = ctx.Administrador.Where(p =>
                    p.Nome.Equals(adm.Nome, StringComparison.CurrentCultureIgnoreCase) ||
                    p.Email.Equals(adm.Email, StringComparison.CurrentCultureIgnoreCase)).ToList();

                if (admin.Count == 0)
                {
                    ctx.Administrador.Add(adm);
                    ctx.SaveChanges();

                    return true;
                }

                return false;
            }
            //noticia.Add(not);
        }

        public IEnumerable<AdmModel> ListarAdministradores()
        {
            var ctx = new ClassContext();

            return ctx.Administrador;
            //return noticia;
        }

        public AdmModel ListarAdministrador(int id)
        {
            using (var ctx = new ClassContext())
            {
                return ctx.Administrador.Where(f => f.IDAdmin == id).First();
            }
            //return noticia.Where(n => n.IDNoticia == codigo).First();
        }

        public void ExcluirAdministrador(int id)
        {
            using (var ctx = new ClassContext())
            {
                AdmModel admin = ctx.Administrador.Where(n => n.IDAdmin == id).First();

                ctx.Administrador.Remove(admin);
                ctx.SaveChanges();
            }
            //noticia.Remove(ListarNoticia(codigo));
        }

        public void AlterarAdministrador(AdmModel adm)
        {
            using (var ctx = new ClassContext())
            {
                AdmModel admin = ctx.Administrador.Where(n => n.IDAdmin == adm.IDAdmin).First();

                admin.Nome = adm.Nome;
                admin.CPF = adm.CPF;
                admin.Logradouro = adm.Logradouro;
                admin.Email = adm.Email;
                admin.DataNascimento = adm.DataNascimento;
                admin.Senha = adm.Senha;
                admin.Status_Adm = adm.Status_Adm;

                ctx.SaveChanges();
            }
            //noticia.Where(n => n.IDNoticia == not.IDNoticia)
            //                            .ToList()
            //                            .ForEach(s =>
            //                            {
            //                                s.Titulo = not.Titulo;
            //                                s.Descricao = not.Descricao;
            //                            });
        }
    }
}