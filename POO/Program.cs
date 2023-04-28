using POO;

Console.Clear();

Personagens p1 = new Personagens();

Console.WriteLine($"Digite o nome :");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade :");
p1.idade = Console.ReadLine();

Console.WriteLine($"Digite o nome da armadura :");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Digite o nome da ia :");
p1.ia = Console.ReadLine();

Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}");

p1.atacar();
p1.defender();
p1.RestaurarArmadura();