using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Model
{
    [Table("Sapato")]
    public class Sapato
    {
        [Key]
        public int IdSapato { get; set; }
        public string Modelo { get; set; }
        public bool Cadarco { get; set; }
        public string Material { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }
        public int Quantidade38 { get; set; }
        public int Quantidade39 { get; set; }
        public int Quantidade40 { get; set; }
        public int Quantidade41 { get; set; }
        public int Quantidade42 { get; set; }
        public int Quantidade43 { get; set; }
        public int Quantidade44 { get; set; }

        public Sapato()
        {

        }
    }
}
