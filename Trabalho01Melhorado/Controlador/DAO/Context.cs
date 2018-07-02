using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Model;

namespace Controlador.DAO
{
    public class Context : DbContext
    {
        public Context() : base("BancoDeDadosSapatoo_[1709292]_[1704844]") { }
        public DbSet<ClientePessoaFisica> ClientesPessoaFisica { get; set; }
        public DbSet<ClientePessoaJuridica> ClientesPessoaJuridica { get; set; }
        public DbSet<Sapato> Sapatos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
