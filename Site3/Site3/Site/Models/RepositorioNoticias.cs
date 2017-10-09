using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class RepositorioNoticias
    {
         private static RepositorioNoticias _repositorio;

        private List<NoticiasModel> noticia;

        private RepositorioNoticias()
        {
            noticia = new List<NoticiasModel>();
        }
        public static RepositorioNoticias Instance()
        {
            if (_repositorio == null)
            {
                _repositorio = new RepositorioNoticias();
            }
            return _repositorio;
        }

        public void IncluirNoticia(NoticiasModel not)
        {
            noticia.Add(not);
        }

        public IEnumerable<NoticiasModel> ListarNoticias()
        {
            return noticia;
        }

        public NoticiasModel ListarNoticia(int codigo)
        {
            return noticia.Where(n => n.Codigo == codigo).First();
        }

        public void ExcluirNoticia(int codigo)
        {
            noticia.Remove(ListarNoticia(codigo));
        }

        public void AlterarNoticia(NoticiasModel not)
        {
            noticia.Where(n => n.Codigo == not.Codigo)
                                        .ToList()
                                        .ForEach(s =>
                                        {
                                            s.Titulo = not.Titulo;
                                            s.Descricao = not.Descricao;
                                        });
        }
    }
}