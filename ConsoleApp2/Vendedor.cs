using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vendedor : Pessoa
    {

        private double comissao;
        private int numeroDeVendas;
        public Vendedor(String cpf, String nome, int idade, char sexo, double comissao = 0.3) : base(cpf, nome,idade,sexo)
        {
            this.comissao = comissao;
        }

        public void vender(Produto produto)
        {
            produto.vender();
            this.receberDinheiro(produto.getValor() * this.comissao);
        }

        private void aumentarVendas()
        {
            this.numeroDeVendas++;
            if(this.numeroDeVendas == 10)
            {
                this.comissao = 0.5;
            }
        }

    }
}
