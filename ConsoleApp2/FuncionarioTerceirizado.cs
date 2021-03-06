using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    // Diferente do FuncionarioMensal, o FuncionarioTerceirizado não apresentará vínculos com a empresa
    // de forma que seu salario será o produto das horas trabalhadas com o valor referente a hora e
    // não apresentará um ID de funcionário. No entanto, ele herda atributos e métodos da classe Pessoa 
     class FuncionarioTerceirizado : Pessoa, Descritivel
    {
        private int horasTrabalhadas = 0;
        private double valorPorHora = 0;


        public FuncionarioTerceirizado(double valorHora, String cpf, String nome, int idade, char sexo) : base(cpf, nome, idade, sexo)
        {
            this.valorPorHora = valorHora;

        }
        public String getTotalDeHoras()
        {
            return "O total de horas trabalhadas é de " + this.horasTrabalhadas + " horas";
        }

        public void addHora()
        {
            this.horasTrabalhadas++;
        }
        public void somarHoras(int horas)
        {
            this.horasTrabalhadas += horas;
        }

        public void receberSalario()
        {
            this.receberDinheiro(this.horasTrabalhadas * this.valorPorHora);
        }

        public String getDescricao()
        {
            return "\n - Nome: " + this.getNome() + " - cpf: " + this.getCpf() + " - saldo: R$ " + this.getSaldo() + " - horas trabalhadas : " + this.horasTrabalhadas + " - valor por hora: " + this.valorPorHora;
        }
    }
}
