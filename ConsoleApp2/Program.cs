using System;


namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Descritivel[] objs = new Descritivel[5];

            // Instâncias de classes abaixo
            Vendedor vendedorObj = new Vendedor("02", "Roberto", 30, 'm');
            Produto produtoObj = new Produto("mesa", "mesa de madeira", 30.99, 5);
            FuncionarioTerceirizado funcionarioTerceirizadoObj = new FuncionarioTerceirizado(50, "01", "João", 20, 'm');
            FuncionarioMensal funcionarioMensalObj = new FuncionarioMensal(3000, 2018, "03", "Rafaela", 25, 'f');
            Comprador compradorObj = new Comprador("Pedrinho", 'm', "04", 45);

            compradorObj.comprar(produtoObj, vendedorObj);
            funcionarioTerceirizadoObj.somarHoras(20);
            funcionarioMensalObj.receberSalario();
            produtoObj.encherEstoque(10);
            vendedorObj.vender(produtoObj);

            objs[0] = vendedorObj;
            objs[1] = produtoObj;
            objs[2] = funcionarioTerceirizadoObj;
            objs[3] = funcionarioMensalObj;
            objs[4] = compradorObj;


            for (int i = 0; i < objs.Length; i++)
            {
                
                Console.WriteLine(objs[i].getDescricao());
            }


        }
    }
}
