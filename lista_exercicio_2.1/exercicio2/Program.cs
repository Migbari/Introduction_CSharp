using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {
            float peso;
            string planeta;
            float calc1, calc2, calc3, calc4, calc5, calc6;

            Console.WriteLine ("Digite seu peso: ");
            peso = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o número do planeta: (1)Mercurio (2)Vênus (3)Marte (4)Júpter (5)Saturno (6)Urano");
            planeta = Console.ReadLine ();

            calc1 = (peso / 10) * 0.37f;
            calc2 = (peso / 10) * 0.88f;
            calc3 = (peso / 10) * 0.38f;
            calc4 = (peso / 10) * 2.68f;
            calc5 = (peso / 10) * 1.15f;
            calc6 = (peso / 10) * 1.17f;

            if (planeta == "1") {
                Console.WriteLine ("Seu peso em Mercurio é: " + calc1);
            } else if (planeta == "2") {
                Console.WriteLine ("Seu peso em Vênus é: " + calc2);
            } else if (planeta == "3") {
                Console.WriteLine ("Seu peso em Marte é: " + calc3);
            } else if (planeta == "4") {
                Console.WriteLine ("Seu peso em Jupter é: " + calc4);
            } else if (planeta == "5") {
                Console.WriteLine ("Seu peso em Saturno é: " + calc5);
            } else if (planeta == "6"){
                Console.WriteLine ("Seu peso em Urano é: " + calc6);
            } else{
                Console.WriteLine ("Inválido");
            }   

        }
    }
}