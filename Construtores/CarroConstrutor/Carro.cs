using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarroConstrutor
{
    public class Carro
    {
        public string Marca {get; set;}

        public string Cor {get; set;}

        public string Placa {get; set;}

        public Carro()
        {

        }

        public Carro(string marca, string cor ,string placa)
        {
            Marca = marca;
            Cor = cor;
            Placa = placa;
        }
    }
}