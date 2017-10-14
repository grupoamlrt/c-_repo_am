using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models.Context
{
    public class RepositorioCliente
    {
        private static RepositorioCliente _repositorio;

        private List<ClienteModel> cliente;

        private RepositorioCliente()
        {
            cliente = new List<ClienteModel>();
        }
        public static RepositorioCliente Instance()
        {
            if (_repositorio == null)
            {
                _repositorio = new RepositorioCliente();
            }
            return _repositorio;
        }

        public void CadastrarCliente(ClienteModel cli)
        {

            using (var ctx = new ClassContext())
            {
                //ctx.Cliente.Add(cli);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<AdmModel> ListarClientes()
        {
            var ctx = new ClassContext();

            //return ctx.Cliente;
            return ctx.Administrador;
        }

        public AdmModel ListarCliente(int id)
        {
            using (var ctx = new ClassContext())
            {
                return ctx.Administrador.Where(f => f.IDAdmin == id).First(); ;
                //return 0;
                //return ctx.Cliente.Where(f => f.IDCliente == id).First();
            }
        }

        public void ExcluirCliente(int id)
        {
            using (var ctx = new ClassContext())
            {
                //ClienteModel cliente = ctx.Cliente.Where(n => n.IDCliente == id).First();

                //ctx.Cliente.Remove(cliente);
                ctx.SaveChanges();
            }
        }

        public void AlterarCliente(ClienteModel cli)
        {
            using (var ctx = new ClassContext())
            {
                //ClienteModel cliente = ctx.Cliente.Where(n => n.IDCliente == cli.IDCliente).First();

                //cliente.Nome = cli.Nome;
                //cliente.CPF = cli.CPF;
                //cliente.Email = cli.Email;
                //cliente.Cidade = cli.Cidade;
                //cliente.Estado = cli.Estado;
                //cliente.Rua = cli.Rua;
                //cliente.CEP = cli.CEP;
                //cliente.DataNascimento = cli.DataNascimento;
                //cliente.Senha = cli.Senha;

                ctx.SaveChanges();
            }
        }
    }
}