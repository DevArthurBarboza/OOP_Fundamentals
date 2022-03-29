using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vendedor : Pessoa, Descritivel 
    {

        private double comissao = 0.3;
        private int numeroDeVendas;
        public Vendedor(String cpf, String nome, int idade, char sexo, double comissao = 0.3) : base(cpf, nome,idade,sexo)
        {
            this.comissao = comissao;

        }

        public void vender(Produto produto)
        {
            produto.vender();
            this.receberDinheiro(produto.getValor() * this.comissao);
            this.aumentarVendas();
        }

        private void aumentarVendas()
        {
            this.numeroDeVendas++;
            if(this.numeroDeVendas == 10)
            {
                this.comissao += 0.15;
            }
        }

        public int getComissao()
        {
            return (int)(comissao * 100);
        }

        public String getDescricao()
        {
            return "\nNome: " + this.getNome() + " cpf: " + this.getCpf() + " saldo: R$" + this.getSaldo() + " comissão: " + (this.comissao * 100) + " número de vendas: " + numeroDeVendas;
        }



    }
}
