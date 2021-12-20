using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projetocrud.Models
{
    public class Agencia
    {
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public String Destino { get; set; }

        public string Contato { get; set; }

        public int Promoção { get; set; }

        public string Endereço { get; set; }


        public String Cidade { get; set; }











    }
}
