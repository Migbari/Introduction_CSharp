using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {

            int numero;
            int acumuladora = 0;

            for (int cont = 1; cont <= 10; cont++) {

                Console.WriteLine ("Digite um numero");
                numero = int.Parse (Console.ReadLine ());

                // acumuladora = acumuladora + numero;
                // Console.WriteLine ("Soma: " + acumuladora);
                
                 // Console.WriteLine("A média é de: "+ (acumuladora / cont));

                if(numero <= -1){
                
                acumuladora = acumuladora + numero;
                Console.WriteLine ($"Soma: {acumuladora}");

                    Console.WriteLine("A média é de: "+ (acumuladora / cont));
                }
               
            }

        }

    }
}