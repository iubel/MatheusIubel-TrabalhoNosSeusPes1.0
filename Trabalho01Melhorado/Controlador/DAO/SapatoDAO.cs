using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Model;

namespace Controlador.DAO
{
    public class SapatoDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        public static bool AdicionarProduto(Sapato sapato)
        {

            try
            {
                ctx.Sapatos.Add(sapato);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoverSapato(Sapato sapato)
        {
            try
            {
                ctx.Sapatos.Remove(sapato);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Sapato BuscarSapatoPorNome(Sapato sapato)
        {
            return ctx.Sapatos.FirstOrDefault(x => x.Modelo.Equals(sapato.Modelo));
        }

        public static Sapato BuscarSapatoPorId(int idSapato)
        {
            return ctx.Sapatos.Find(idSapato);
        }

        public static bool AlterarSapato(Sapato sapato)
        {
            try
            {
                ctx.Entry(sapato).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public static List<Sapato> RetorarSapatoPorNome(Sapato sapato)
        {
            return ctx.Sapatos.Where<Sapato>(x => x.Modelo == sapato.Modelo).ToList();
        }

        public static IList<Sapato> RetornarLista()
        {
            return ctx.Sapatos.ToList();
        }
    }
}
