using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContatoInterface
{
    public class ContatoComercial : Contato, IContatoComercial 
    {
        public string Cnpj;

        public bool ValidarCnpj(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}