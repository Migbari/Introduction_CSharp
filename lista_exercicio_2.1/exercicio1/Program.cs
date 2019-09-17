using System;

namespace exercicio1 {
    class Program {
        static void Main (string[] args) {
            string lanche;

            Console.Write ("Digite o número do pedido (1, 2, 3 ou 4): ");
            lanche = Console.ReadLine ();

            if (lanche == "1") {
                lanche = "If/Else - Hamburguer";
            } else if (lanche == "2") {
                lanche = "If/Else - Cheese Salada";
            } else if (lanche == "3") {
                lanche = "If/Else - Cheese Burguer";
            } else if (lanche == "4"){
                lanche = "If/Else - Cheese Bacon";
            } else {
                lanche = "Pedido Inválido!";
            }

            Console.Write(lanche);

            
        }
    }
}