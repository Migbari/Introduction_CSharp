using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {

            int numero;
            int acumuladora = 0;
            int contNegativo =0;


            for (int cont = 1; cont <= 3; cont++) {

                Console.WriteLine ("Digite um numero");
                numero = int.Parse (Console.ReadLine ());

                if (numero <= -1) {
                    contNegativo++; // contador adicionado para contar os negativos 
                    acumuladora = acumuladora + numero; 
                    Console.WriteLine ("Soma dos negativos é: " +acumuladora);

                    Console.WriteLine("Media: "+acumuladora/contNegativo);

                }
            }


            
            

    


        }

    }
}