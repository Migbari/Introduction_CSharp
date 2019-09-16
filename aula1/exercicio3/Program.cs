using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 3
            int salario;
            int produtosvendidos;
            int retorno;
            int total;      

             //Exercício 3
            Console.WriteLine("Informe valor do salário: ");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em R$ sobre vendas: ");
            produtosvendidos = int.Parse(Console.ReadLine());

            retorno = (produtosvendidos*5)/100;

            total = retorno+salario;
            Console.WriteLine("Seu salári0 + comissão é: " +total); // end
        }
    }
}
