//Estruturas Condicionais - Switch / Case

Console.WriteLine($"Informe o número correspondente ao dia da semana: ");
int dias = int.Parse(Console.ReadLine());

switch (dias)
{
    case 1:
        Console.WriteLine($"Domingo"); 
    break;

    case 2:
        Console.WriteLine($"Segunda");
    break;
    
    case 3:
        Console.WriteLine($"Terça");
    break;
    
    case 4:
        Console.WriteLine($"Quarta");
    break;
    
    case 5:
        Console.WriteLine($"Quinta");
    break;
    
    case 6:
        Console.WriteLine($"Sexta");
    break;

     case 7:
        Console.WriteLine($"Sabado");
    break;
        
    default:
        Console.WriteLine($"O número digitado é inválido");
    break;    
}