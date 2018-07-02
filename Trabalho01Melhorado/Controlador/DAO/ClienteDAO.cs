using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Model;

namespace Controlador.DAO
{
    public class ClienteDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        public static bool CadastrarClientePessoaFisica(ClientePessoaFisica clientePessoaFisica)
        {
            try
            {
                ctx.ClientesPessoaFisica.Add(clientePessoaFisica);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static ClientePessoaFisica BuscarClientePessoaFisicaPorId(int idCliente)
        {
            return ctx.ClientesPessoaFisica.Find(idCliente);
        }

        public static List<ClientePessoaFisica> RetornarListaPessoaFisica()
        {
            return ctx.ClientesPessoaFisica.ToList();
        }

        public static bool CadastrarClientePessoaJuridica(ClientePessoaJuridica clientePessoaJuridica)
        {
            try
            {
                ctx.ClientesPessoaJuridica.Add(clientePessoaJuridica);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static ClientePessoaJuridica BuscarClientePessoaJuridicaPorId(int idCliente)
        {
            return ctx.ClientesPessoaJuridica.Find(idCliente);
        }

        public static List<ClientePessoaJuridica> RetornarListaClientePessoaJuridica()
        {
            return ctx.ClientesPessoaJuridica.ToList();
        }
    }
}
