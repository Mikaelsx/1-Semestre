// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <= 10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Informe o nome do produto: ");
string produto = Console.ReadLine();

Console.WriteLine($"Informe a quantidade do produto: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o preço do produto: ");
float custo = float.Parse(Console.ReadLine());

float total = quantidade * custo;
float pagar;

if (quantidade <= 5)
{
pagar = total - (total * 0.02F);
}
else if (quantidade > 5 && quantidade <= 10)
{
pagar = total - (total * 0.03F);
}
else
{
pagar = total - (total * 0.05F);
}

Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine(@$"
O valor total é: {pagar}");
Console.ResetColor();