using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
             //ex 4
            double real;
            double dolar;
            double conversao; 

            //Ex 4
            Console.WriteLine("Informe o valor em R$: ");
            real = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação U$: ");
            dolar = double.Parse(Console.ReadLine());

            conversao = real/dolar;
            Console.WriteLine("O valor em dólar é: " + conversao);  // end   

        }
    }
}
