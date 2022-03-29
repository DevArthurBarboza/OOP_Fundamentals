using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Comprador : Pessoa
    {

        public String produtoComprado;
        public int quantidade;

        public Comprador(String nome, char sexo, String cpf, int idade) : base(cpf, nome, idade, sexo)
        {

        }

        public void Comprar(Produto prodObj)
        {
            this.produtoComprado = prodObj.getNome();
            prodObj.vender();
            if(prodObj.getNome() == this.produtoComprado)
            {
                this.quantidade++;
            } else
            {
                this.quantidade = 1;
            }

        }
    }
}
