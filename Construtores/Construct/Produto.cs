using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construct
{
    public class Produto
    {
        public string Codigo {get; set;}
        public string Nome {get; set;}
        public float preco {get; set;}

        public Produto(string codigo, string nome, float preco);
    }
}