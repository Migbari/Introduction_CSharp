using System;

namespace aula1exercicios
{
    class Program
    {
        static void Main(string[] args)

        {   //ex 1
            int valor;
            int resultado;

 
            Console.WriteLine("Digite um número: ");
            valor = int.Parse(Console.ReadLine());

            resultado = valor*3;
            Console.WriteLine("Seu triplo é: " + resultado);  // end       
        }

    }
}
