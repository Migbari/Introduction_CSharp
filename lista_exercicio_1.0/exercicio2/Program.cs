using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
             //ex 2
            int custo;
            int venda;

             //Exercício 2
            Console.WriteLine("Informe o custo");
            custo = int.Parse(Console.ReadLine());

            venda = (custo*40)/100;
            Console.WriteLine("O preço da venda é 40% a mais, ou seja: "+venda);  // end  
        }
    }
}
