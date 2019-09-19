using System;

namespace aula3_1 {
    class Program {
        static void Main (string[] args) {
            // LAÇO CONTATDO - FOR - INCREMENTO (+)
            for (int cont = 1; cont <= 100; cont++) {
                // Estrutura condicional simples   
                // Verificamos se o número é diferente de par
                if (cont % 2 != 0) { // Se (condição) então 
                    Console.WriteLine ("FOR 0 à 100: " + cont); // Escreva (cont)
                }

            }
            // LAÇO CONTADO - FOR - DECREMENTO     
                for (int cont = 100; cont >= 0; cont--) {
                if (cont % 2 != 0) { // Se (condição) então 
                    Console.WriteLine ("FOR 100 à 0: " + cont); // Escreva (cont)
                }
            }
        }
    }
}