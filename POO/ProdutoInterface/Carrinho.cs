using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoInterface
{
    public class Carrinho : ICarrinho
    {

        public float valor {get; set;}

        //Criar lista para manipular os objetos

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo)!.Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            if(carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
Console.WriteLine(@$"
Códido: {p.Codigo}
Nome: {p.Nome}
Preço: {p.Preco}");
Console.WriteLine($"");  
                }
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
            
        }

        public void TotalCarrinho()
        {
            valor = 0;

            if(carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    valor += p.Preco;

                    Console.WriteLine($"O valor total do seu carrinho é: {valor:C}");
                }
            }
            
            else
            {
                Console.WriteLine($"Carrinho vazio!");
            }
                
        }
    }
}