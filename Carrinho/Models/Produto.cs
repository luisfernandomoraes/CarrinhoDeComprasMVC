using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Carrinho.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(250)]
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return "produto";
        }
    }
}