using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numero = new int [10]; 

            for (int i = 0; i <= 9; i++){

                Console.WriteLine("Digite um número");
                numero[i] = int.Parse(Console.ReadLine() ); 
            }
            Console.WriteLine("Valor "+numero[9]*5); // Pegar indice 9 da lista numero.


        }
    }
}
