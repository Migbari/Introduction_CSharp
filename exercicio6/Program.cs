using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
           
             //ex 6
            int salario;
            int contas;
            int sobra;
                        
            //Exercício 6
            Console.WriteLine("Informe valor do salário: ");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de dívidas a pagar em R$: ");
            contas = int.Parse(Console.ReadLine());

            sobra = contas-salario;

           
            Console.WriteLine("Seu salári0 é: "+salario);   
            Console.WriteLine("Suas dívidas são de:" +contas);
            Console.WriteLine("Valor restante: "+sobra); // end
        }
    }
}
