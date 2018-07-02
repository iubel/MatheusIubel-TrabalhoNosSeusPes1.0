using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Model
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public string Modelo { get; set; }
        public int Quantidade38 { get; set; }
        public int Quantidade39 { get; set; }
        public int Quantidade40 { get; set; }
        public int Quantidade41 { get; set; }
        public int Quantidade42 { get; set; }
        public int Quantidade43 { get; set; }
        public int Quantidade44 { get; set; }
        public double PrecoUnidade { get; set; }
        public double PrecoTotal { get; set; }
        public ClientePessoaFisica ClientePessoaFisica { get; set; }
        public ClientePessoaJuridica ClientePessoaJuridica { get; set; }

    }
}
