// Crie uma classe produto
// Com as propriedades : int código, string nome, float preco
// Crie um construtor vazio
// Crie um construtor completo

using Exercicio_Construtores;

Console.Clear();

// Criar lista de objetos(produtos)
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(5634,"Vans Old School",499.99f)
);

produtos.Add(
    new Produto(0435,"Moleton Grizzly",199.99f)
);

Produto calcaLevis = new Produto(1436,"Calça Levis",200.00f);

produtos.Add(calcaLevis);

foreach (var item in produtos)
{
    Console.ForegroundColor=ConsoleColor.Magenta;
    Console.WriteLine($"Código{item.Codigo}, Nome{item.Nome}, Preço{item.Preco:C} {produtos.IndexOf(item)}");
    Console.ResetColor();
}

// Update

Produto produtoBuscado = produtos.Find(x => x.Codigo == 3424)!;

Console.WriteLine($"{produtoBuscado.Codigo}, {produtoBuscado.Nome}, {produtoBuscado.Preco}");

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

Console.WriteLine($"Lista atualizada");
Console.WriteLine($"----------------");

foreach (var item in produtos)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Código :{item.Codigo}, Nome :{item.Nome}, Preço :{item.Preco:C} {produtos.IndexOf(item)}");
    Console.ResetColor();
}


