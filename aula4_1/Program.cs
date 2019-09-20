using System;

namespace aula4_1 {
    class Program {
        static void Main (string[] args) {

            double[] media = new double[10];

            for (int i = 0; i <= 9; i++) {

                Console.Write ("Digite uma média: ");
                media[i] = double.Parse (Console.ReadLine ());

            }

            Console.WriteLine (media[3]);
            Console.WriteLine();

            for (int i = 0; i <= media.Length -1; i++) { // length se inicia de 1 / vetor a do 0, sendo 0 seu primeiro elemento
            // Nesse caso é necessario igualar length com oe do vetor / media.Length -1
                Console.WriteLine("Valores: "+media[i]);
            }







        }
    }
}