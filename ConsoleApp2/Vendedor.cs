using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vendedor : Pessoa
    {

        private double comissao = 0.30 ;
        public Vendedor(int cpf, String nome, int idade, char sexo, double comissao) : base(cpf, nome,idade,sexo)
        {
            this.comissao = comissao;
        }

        public void vender(Produto produto)
        {
            produto.vender();
            this.receberDinheiro(produto.getValor() * this.comissao);
        }

    }
}
