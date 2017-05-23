using MvcAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAngular.Controllers
{
    public class HomeController : Controller
    {
        public static List<Produto> produtos = new List<Produto>
            {
                new Produto {Id = 1, ProdutoNome = "Produto1", ProdutoPreco = 123},
                new Produto {Id = 2, ProdutoNome = "Produto2", ProdutoPreco = 456}
            };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProdutos()
        {
            return Json(produtos);
        }


        public ActionResult InsertProduto()
        {
            return View("Post");
        }

        [HttpPost]
        public ActionResult InsertProduto(Produto produto)
        {
            //Insert no BD/Lista parametro produto
            produtos.Add(produto);
            return View();
        }


    }
}