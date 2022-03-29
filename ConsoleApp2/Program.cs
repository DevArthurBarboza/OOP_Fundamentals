using System;


namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {

            // Instâncias de classes abaixo
            Vendedor vendObj = new Vendedor(02, "Roberto", 30, 'm');
            Produto prodObj = new Produto("mesa", "mesa de madeira", 30.99);
            FuncionarioTerceirizado FuncTerObj = new FuncionarioTerceirizado(50, 01, "João", 20, 'm');
            FuncionarioMensal FunMenObj = new FuncionarioMensal(3000, 2018, 03, "Rafaela", 25, 'f');

            Console.WriteLine("Vendedor : " + vendObj.getNome() + "\n");
            Console.WriteLine("Vendedor : " + vendObj.getNome() + "\n");
            Console.WriteLine("Vendedor : " + vendObj.getNome() + "\n");


        }
    }
}
