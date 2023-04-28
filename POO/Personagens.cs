using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Personagens
    {
        public string nome;

        public string idade;

        public string armadura;

        public string ia;

        public void atacar()
    {
        Console.WriteLine($"O personagem atacou");
    }
        public void defender()
    {
        Console.WriteLine($"O personagem defendeu");
    }
        public void RestaurarArmadura()
    {
        Console.WriteLine($"Armadura restaurada");
    }
    }
}