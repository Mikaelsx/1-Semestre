// Criar um projeto de console
// Criar uma classe carro
// - Marca
// - Cor
// Criar um construtor vazio e completo
// Receber dados no console para adcionar 2 objetos em uma lista
// Exibir os dois objetos da lista no console

using CarroConstrutor;

Console.Clear();

List<Carro> carros = new List<Carro>();
for (int i = 0; i < 2; i++)
{
Console.WriteLine($"Qual a marca do carro ?");
string marca = Console.ReadLine()!;
Console.WriteLine($"");


Console.WriteLine($"Qual a cor do carro ?");
string cor = Console.ReadLine()!;
Console.WriteLine($"");


Console.WriteLine($"Qual a placa do carro ?");
string placa = Console.ReadLine()!;
Console.WriteLine($"");


carros.Add(
    new Carro(marca, cor, placa)
);
}

// carros.Add(new Carro("Ferrari","Roxa","AWM2344"));

// carros.Add(new Carro("Nissam","Laranja","APX4643"));

foreach (var item in carros)
{
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine(@$"
Marca :{item.Marca}
Cor :{item.Cor}
Placa :{item.Placa}");
Console.ResetColor();
}