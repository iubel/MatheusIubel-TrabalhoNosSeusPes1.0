using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Model;

namespace Controlador.DAO
{
    public class PedidoDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        public static bool AdicionarPedido(Pedido pedido)
        {
            try
            {
                ctx.Pedidos.Add(pedido);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
