using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class Repositorio
    {
        //private static Repositorio _repositorio;

        //private List<ClienteModel> cliente;

        //private Repositorio()
        //{
        //    cliente = new List<ClienteModel>();
        //}
        //public static Repositorio Instance()
        //{
        //    if (_repositorio == null)
        //    {
        //        _repositorio = new Repositorio();
        //    }
        //    return _repositorio;
        //}

        //public void IncluirFuncionario(ClienteModel cli)
        //{
        //    cliente.Add(cli);
        //}

        //public IEnumerable<ClienteModel> ListarFuncionarios()
        //{
        //    return cliente;
        //}

        //public ClienteModel ListarFuncionario(int codigo)
        //{
        //    return cliente.Where(c => c.Codigo == codigo).First();
        //}

        //public void ExcluirFuncionario(int codigo)
        //{
        //    cliente.Remove(ListarFuncionario(codigo));
        //}

        //public void AlterarFuncionario(ClienteModel cli)
        //{
        //    cliente.Where(c => c.Codigo == cli.Codigo)
        //                                .ToList()
        //                                .ForEach(s =>
        //                                {
        //                                    s.Nome = cli.Nome;
        //                                    s.Logradouro = cli.Logradouro;
        //                                    s.Email = cli.Email;
        //                                    s.Idade = cli.Idade;
        //                                });
        //}
    }
}