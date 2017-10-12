using Site.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class RepositorioContato
    {
               private static RepositorioContato _repositorio;

               private List<ContatoModel> contato;

        private RepositorioContato()
        {
            contato = new List<ContatoModel>();
        }
        public static RepositorioContato Instance()
        {
            if (_repositorio == null)
            {
                _repositorio = new RepositorioContato();
            }
            return _repositorio;
        }

        public void CadastrarContato(ContatoModel not)
        {

            using (var ctx = new ClassContext())
            {
                ctx.Contato.Add(not);
                ctx.SaveChanges();
            }
            //noticia.Add(not);
        }

        public IEnumerable<ContatoModel> ListarContatos()
        {
            var ctx = new ClassContext();

            return ctx.Contato;
            //return noticia;
        }

        public ContatoModel ListarContatos(int id)
        {
            using (var ctx = new ClassContext())
            {
                return ctx.Contato.Where(f => f.IDContato == id).First();
            }
            //return noticia.Where(n => n.IDNoticia == codigo).First();
        }

        public void ExcluirContato(int id)
        {
            using (var ctx = new ClassContext())
            {
                ContatoModel contato = ctx.Contato.Where(n => n.IDContato == id).First();

                ctx.Contato.Remove(contato);
                ctx.SaveChanges();
            }
            //noticia.Remove(ListarNoticia(codigo));
        }

        public void AlterarContato(ContatoModel con)
        {
            using (var ctx = new ClassContext())
            {
                ContatoModel contato = ctx.Contato.Where(n => n.IDContato == con.IDContato).First();

                contato.NomeContato = con.NomeContato;
                contato.EmailContato = con.NomeContato;
                contato.Mensagem = con.NomeContato;

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