using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrinho.Models
{
    public class Compra
    {
        public int ID { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}