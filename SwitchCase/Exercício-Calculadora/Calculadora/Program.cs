//Estrutura condicional Switch / Case

//Calculadora

//1.Informar a operação
//2.Informar o primeiro número
//3.Informar o segundo número
//4.Processar os dados
//5.Exibir o resultado

//Entrada 
Console.WriteLine(@$"

Calculadora

Informe a operação:

+ Soma
- Subtração
* Multiplicação
/ Divisão
");
char operação = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro número");
double N1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
double N2 = double.Parse(Console.ReadLine());

double resultado = 0;

//Processamento

//Saída

switch(operação){

    case '+':
     resultado =  (N1 + N2);
     Console.WriteLine($"O resultado da soma é igual á: {resultado}");
    break;

    case '-':
     resultado =  (N1 - N2);
      Console.WriteLine($"O resultado da subtração é igual á: {resultado}");
    break;

    case '*':
     resultado =  (N1 * N2);
      Console.WriteLine($"O resultado da multiplicação é igual á: {resultado}");
    break;

    case '/':
     resultado =  (N1 / N2);
      Console.WriteLine($"O resultado da divisão é igual á: {resultado}");
    break;

    default:
        Console.WriteLine($"Erro de Sintaxe");
    break;
}