using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoInterface
{
    public interface ICarrinho
    {
        //Regras do "Contrato"
        //Métodos declarados
        
        //Crud: Create, Read, Update, Delete.

        //Create
        //Tipo nome(Parâmetros)

        void Adicionar(Produto _produto);

        //Read

        void Listar();

        //Update

        void Atualizar(int _codigo, Produto _produto);

        //Delete

        void Remover(Produto _produto);

    }
}