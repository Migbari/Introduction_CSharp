using System;

namespace aula4_1 {
    class Program {
        static void Main (string[] args) {

            double[] media = new double[10];

            for (int i = 0; i <= 9; i++) {

                Console.Write ("Digite uma média: ");
                media[i] = double.Parse (Console.ReadLine ()); // Parse do array
            }

            Console.WriteLine (media[3]); // Mostra indice 3 da lista.
            Console.WriteLine(); // Apenas para um espaçamento

            for (int i = 0; i <= media.Length -1; i++) { // Length se inicia de 1 / vetor a do 0
            // Nesse caso é necessario igualar length com o vetor / media.Length -1
                Console.WriteLine("Valores: "+media[i]);
            }
            



        }
    }
}