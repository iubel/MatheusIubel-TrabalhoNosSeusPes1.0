using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Model
{
    [Table("ClientesPessoaJuridica")]
    public class ClientePessoaJuridica : Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
    }
}
