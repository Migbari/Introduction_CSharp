    using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Primeiro vetor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Segundo vetor: ");
                vetor2[i] = int.Parse (Console.ReadLine ());

                 vetor3[i] = vetor1[i];
                 vetor3[i + 10] = vetor2[i]; // Digo que irei armazenar a partir do indice 10 sendo o vetor3 com 20 posições.
            }
            for (int i = 0; i <= 19; i++){
                Console.WriteLine ("Terceiro Vetor: " + vetor3[i]);
            }


        }
    }
}