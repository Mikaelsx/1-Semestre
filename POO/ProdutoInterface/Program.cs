//Instância do objeto carrinho
using ProdutoInterface;

Carrinho carrinho = new Carrinho();

Console.Clear();

//Instânciar objetos da classe produtos
Produto p1 = new Produto(1,"The Witcher",109.90f);
Produto p2 = new Produto(2,"Brawllhala",0.00f);
Produto p3 = new Produto(3,"Doom",49.00f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();


Console.WriteLine($"Após a remoção de um item");

carrinho.Remover(p1);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//Criar novo objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "Bomba patch";
_novoProduto.Preco = 20.00f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();

