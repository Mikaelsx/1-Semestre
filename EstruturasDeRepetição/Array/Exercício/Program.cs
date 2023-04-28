//Sem array//

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"Digite o nome do carro");
// carro1 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro");
// carro2 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro");
// carro3 = Console.ReadLine();

// Console.ForegroundColor=ConsoleColor.Green;
// Console.WriteLine($"{carro1},{carro2},{carro3}");
// Console.ResetColor();

//Com array//

// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro: ");
// carros[0] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carros[1] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carros[2] = Console.ReadLine();

// Console.ForegroundColor=ConsoleColor.Green;
// Console.WriteLine(@$"
// Carros da lista: 
// {carros[0]}
// {carros[1]}
// {carros[2]}");
// Console.ResetColor();

//Array + for//

// string[]carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Digite o nome do carro: ");
//     carros[i] = Console.ReadLine();
// }

// for (int i = 0; i < 3; i++)
// {
//     Console.ForegroundColor=ConsoleColor.Green;
//     Console.WriteLine($"Nome do carro: {carros[i]}");
//     Console.ResetColor();
// }

// foreach (string item in carros)
// {
//     Console.WriteLine($"Nome do carro: {item}");
// }

//Array + for - Exercício

string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do {i + 1}° carro");
    carros[i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}° carro é {carros[i]}");
}