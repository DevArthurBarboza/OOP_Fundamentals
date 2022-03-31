using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    // A classe funcionário herda da classe pessoa

    //Logo todos os atributos e métodos presentes na classe Pessoa também se fazem presente
    //na classe funcionário, de modo que possamos reaproveitar o código e evitar repetições desnecessárias
    class FuncionarioMensal : Pessoa, Descritivel
    {
        
        private int idFuncionario;  //Identificador do funcionario (esse atributo não deve repetir)

        private static int proximoId = 0; // Atribute estático inacessível fora da classe (encapsulamento)
        private double salarioMensal;
        private int anoDeContratacao;


        // Através do encapsulamento eu garanto a segurança de meus dados que não poderão ser alterados
        // por quaisquer outros objetos ou algorítmos com exceção dos métodos presentes na declaração desta classe
        // Os atributos de um objeto, jamais devem ser alterados diretamente por outros objetos, e sim por métodos do próprio 


        // Construtor
        public FuncionarioMensal(double salario, int ano, String cpf, String nome, int idade, char sexo) : base(cpf, nome, idade, sexo)
        {
            this.salarioMensal = salario;
            this.anoDeContratacao = ano;
            this.setId();
        }

        public String getDescricao()
        {
            return "\n - Nome: " + this.getNome() + " - cpf: " + this.getCpf() + " - saldo: R$" + this.getSaldo() + " - identificador de funcionário mensal : "  + this.idFuncionario + " - salário mensal: R$" + this.salarioMensal + " - ano de contratação: " + anoDeContratacao ;

        }



        private void setId()    // Método inacessível fora da classe (encapsulamento)
        {
            this.idFuncionario = proximoId++;
        }

        public void receberSalario()
        {
            this.receberDinheiro(this.salarioMensal);
        }

    }
}
