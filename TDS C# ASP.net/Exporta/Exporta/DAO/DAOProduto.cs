using Exporta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exporta.DAO
{
    public  static class DAOProduto
    {
        public static List<Produto> ListaProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            Produto p1 = new Produto
            {
                Codigo = 1,
                Descricao = "Teclado",
                Grupo = "Informatica",
                Quantidade = 3,
                Valor = 50
            };
        Produto p2 = new Produto
        {
            Codigo = 2,
            Descricao = "Teclado",
            Grupo = "Informatica",
            Quantidade = 3,
            Valor = 50
        };
        Produto p3 = new Produto
        {
            Codigo = 3,
            Descricao = "Teclado",
            Grupo = "Informatica",
            Quantidade = 3,
            Valor = 50
        };

            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);

            return produtos;
    }
}

}