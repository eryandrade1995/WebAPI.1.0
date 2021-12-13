using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIHagloo.Models;

namespace WebAPIHagloo.Controllers
{
    public class ProdutoController : ApiController
    {
        Produto[] produtos = new Produto[]
        {
            new Produto { Id = 1, Nome = "Enantato de Testosterona", Categoria = "Testosterona", Preco = 140.00M, Mg = 250},
            new Produto { Id = 2, Nome = "Cipionato de Testosterona", Categoria = "Testosterona", Preco = 130.00M, Mg = 200},
            new Produto { Id = 3, Nome = "Decanoato de Nandrolona", Categoria = "Nandrolona", Preco = 130.00M, Mg = 200},
            new Produto { Id = 4, Nome = "Proprionato de Testosterona", Categoria = "Testosterona", Preco = 110.00M, Mg = 100},
            new Produto { Id = 5, Nome = "Femproprionato de Nandrolona", Categoria = "Nandrolona", Preco = 150.00M, Mg = 100},
        };
        public IEnumerable<Produto>GetTodosProdutos()
        {
            return produtos;
        }
        public IHttpActionResult GetProduto(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }
        public IEnumerable<Produto> GetProdutosPorCategoria(string categ)
        {
            return produtos.Where(p => string.Equals(p.Categoria, categ, StringComparison.OrdinalIgnoreCase));
        }
    }
}
