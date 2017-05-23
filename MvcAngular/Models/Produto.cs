using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAngular.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal ProdutoPreco { get; set; }
        public string ProdutoNome { get; set; }
    }
}