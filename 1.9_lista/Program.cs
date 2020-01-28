using System;

namespace aula4_2 {
    class Program {
        static void Main (string[] args) {

            string[] series1 = new string[10];
            string[] series2 = new string[10];

            for (int i = 0; i <= 9; i++) {

                Console.Write ("Digite o nome de uma série: ");  // alimenta o array
                series1[i] = Console.ReadLine ();
            }

            for (int i = 0; i <= 9; i++) {  // transfere de um para outro / de serie1 para serie2
               series2[i] = series1[i];
            }

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine (series2[i]); // verifica se funcionou ou nao 
            }

        }
    }
}