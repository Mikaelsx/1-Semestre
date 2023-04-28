// 1- Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Informe o ano atual: ");
int year = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a data de seu nascimento: ");
int nasci = int.Parse(Console.ReadLine());

if (year - nasci >= 16) {
    Console.WriteLine($"Vocé esta já pode votar!");
    
}

else {
    Console.WriteLine($"Você ainda não pode votar."); 
}

