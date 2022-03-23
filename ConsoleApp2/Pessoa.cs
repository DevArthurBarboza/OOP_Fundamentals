using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //Classe pessoa
    class Pessoa
    {

        // Atributos
        private int cpf; // Identificador de pessoa (esse atributo não deve repetir)
        private String nome;
        private int idade;
        private char sexo;
        private double saldoBancario;

        // Metodo getter para retorno do valor referente a idade do objeto Pessoa
        public int getIdade()
        {
            return this.idade;
        }


        // Metodo setter que utiliza de parâmetros para "setar" a idade do objeto Pessoa
        public void setIdade(int novaIdade)
        {
            this.idade = novaIdade;
        }

        // Metodo setter que utiliza de parâmetros para "setar" novo nome do objeto Pessoa
        public String alterarNome(String novoNome)
        {
            this.nome = novoNome;
            return "Seu novo nome é: " + this.nome;
        }

        public String getSaldo()
        {
            return "Seu saldo total é de : R$" + this.saldoBancario;
        }

        public Pessoa(int cpf, String nome, int idade, char sexo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.saldoBancario = 0;
        }

        protected void receberDinheiro(double dinheiro)
        {
            this.saldoBancario += dinheiro;
        }

        

    }
}
