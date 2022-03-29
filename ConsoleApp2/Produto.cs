using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Produto : Descritivel
    {
        private bool emEstoque = true;
        private bool disponivel = true;
        private int quantidade = 1;
        private string nome;
        private string descricao;
        private double valor;


        public Produto(string nome, string descricao, double valor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        
        }

        public Produto(string nome, string descricao, double valor, int qntd)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
            this.quantidade = qntd;

        }

        public String getDescricao()
        {
            return "\nproduto: " + nome + " descrição: " + descricao + " valor: R$" + valor + " quantidade: " + quantidade + " em estoque : " + emEstoque ;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void vender() {
            this.quantidade--;
            if (this.quantidade == 0)
            {
                this.emEstoque = false;
                this.disponivel = false;

            }
            
        }

        public void encherEstoque(int produtos)
        {
            this.quantidade += produtos;
        }

        public double getValor()
        {
            return this.valor;
        }
    }
}
