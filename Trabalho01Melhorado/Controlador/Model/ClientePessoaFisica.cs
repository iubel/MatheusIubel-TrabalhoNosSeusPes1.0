using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Model
{
    [Table("ClientesPessoaFisica")]
    public class ClientePessoaFisica : Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
