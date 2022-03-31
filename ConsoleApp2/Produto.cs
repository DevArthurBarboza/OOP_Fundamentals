using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Produto : Descritivel
    {
        public String status = "disponivel";
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
            return "\n - produto: " + this.nome + " - descrição: " + this.descricao + " - valor: R$" + this.valor + " - quantidade: " + this.quantidade + " - status : " +  this.status;
        }

        public String getNome()
        {
            return this.nome;
        }

        public bool vender() {
            if (this.quantidade > 0)
            {
                this.quantidade--;
                if (this.quantidade == 0)
                {
                    this.status = "indisponivel";


                } else 
                {
                    this.status = "disponivel";
                }
                return true;
            }
            return false;
           
        }

        public void encherEstoque(int produtos)
        {
            this.quantidade += produtos;
            if(this.quantidade > 0)
            {
                this.status = "disponivel";
            }
        }

        public double getValor()
        {
            return this.valor;
        }
    }
}
