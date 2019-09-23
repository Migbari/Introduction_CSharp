using System;

namespace exercicio3 {
    class Program {
        static void Main (string[] args) {

            string[] vetor = new string[2];

            for (int i = 0; i <= 1; i++) {
                Console.Write ("Nome do produto: ");
                vetor[i] = Console.ReadLine ();

                Console.Write ("Cor: ");
                vetor[i] = Console.ReadLine ();

                Console.WriteLine(vetor[i]);
                    
            }            
                
             
          
        }
    }
}