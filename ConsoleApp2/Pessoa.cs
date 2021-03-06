using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //Classe pessoa
    abstract class Pessoa  
    {

        // Atributos
        private String cpf; // Identificador de pessoa (esse atributo não deve repetir)
        private String nome;
        private int idade;
        private char sexo;
        private double saldoBancario = 100;


        // Metodo getter para retorno do valor referente a idade do objeto Pessoa
        public int getIdade()
        {
            return this.idade;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getCpf()
        {
            return this.cpf;
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

        public double getSaldo()
        {
            return this.saldoBancario;
        }

        public Pessoa(String cpf, String nome, int idade, char sexo)
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
