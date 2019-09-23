using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] vetor1 = new int [10];
            int [] vetor2 = new int [10];
            int [] vetor3 = new int [10];

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Digite valor-vetor1");
                vetor1 [i] = int.Parse(Console.ReadLine() );

                Console.WriteLine("Digite valor-vetor2");
                vetor2 [i] = int.Parse(Console.ReadLine() );

                vetor3 [i] = vetor2 [i] + vetor1 [i];
            }
           for(int i = 0; i <= 9; i++){
               Console.WriteLine("Exibição da soma no Vetor 3: "+vetor3[i]);
           }



        }
    }
}
