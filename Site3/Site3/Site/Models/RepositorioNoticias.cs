﻿using Site.Models.Context;
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

            using (var ctx = new ClassContext())
            {
                ctx.Noticia.Add(not);
                ctx.SaveChanges();
            }
            //noticia.Add(not);
        }

        public IEnumerable<NoticiasModel> ListarNoticias()
        {
            var ctx = new ClassContext();

            return ctx.Noticia;
            //return noticia;
        }

        public NoticiasModel ListarNoticia(int id)
        {
            using (var ctx = new ClassContext())
            {
                return ctx.Noticia.Where(f => f.IDNoticia == id).First();
            }
            //return noticia.Where(n => n.IDNoticia == codigo).First();
        }

        public void ExcluirNoticia(int id)
        {
            using (var ctx = new ClassContext())
            {
                NoticiasModel noticia = ctx.Noticia.Where(n => n.IDNoticia == id).First();

                ctx.Noticia.Remove(noticia);
                ctx.SaveChanges();
            }
            //noticia.Remove(ListarNoticia(codigo));
        }

        public void AlterarNoticia(NoticiasModel not)
        {
            using (var ctx = new ClassContext())
            {
                NoticiasModel noticia = ctx.Noticia.Where(n => n.IDNoticia == not.IDNoticia).First();

                noticia.Titulo = not.Titulo;
                noticia.Descricao = not.Descricao;
                noticia.Imagem = not.Imagem;
                noticia.DataNoticia = not.DataNoticia;

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