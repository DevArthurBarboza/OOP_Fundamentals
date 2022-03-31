using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Comprador : Pessoa, Descritivel
    {

        public String produtoComprado;
        public int quantidade;

        public Comprador(String nome, char sexo, String cpf, int idade) : base(cpf, nome, idade, sexo)
        {
            


        }

       



        public String getDescricao()
        {
            return "\n- Nome: " + this.getNome() + " - cpf: " + this.getCpf()+ " - saldo: R$" + this.getSaldo() + " - produto comprado: " + produtoComprado + " - quantidade do produto " + quantidade;
        }

        public void comprar(Produto prodObj, Vendedor vendedorObj)
        {
            if (vendedorObj.vender(prodObj))
            {
                this.produtoComprado = prodObj.getNome();
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
}
