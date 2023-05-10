using Construct;

Produto p3 = new Produto();

Console.WriteLine($"Informe o código :");
p3.Codigo = Console.ReadLine()!;

Console.WriteLine($"Informe o nome :");
p3.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe o preço :");
p3.preco = float.Parse(Console.ReadLine()!);
