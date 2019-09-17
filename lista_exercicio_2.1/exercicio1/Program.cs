using System;

namespace exercicio1 {
    class Program {
        static void Main (string[] args) {
            string lanche, resultado;

            Console.Write ("Digite o número do pedido (1, 2, 3 ou 4): ");
            lanche = Console.ReadLine ();

            if (lanche == "1") {
                lanche = "If/Else - Hamburguer";
            } else if (lanche == "2") {
                lanche = "If/Else - Cheese_Salada";
            } else if (lanche == "3") {
                lanche = "If/Else - Cheese_Burguer";
            } else if (lanche == "4") {
                lanche = "If/Else - Cheese_Bacon";
            } else {
                lanche = "Pedido_Inválido!";
            }
            Console.Write (lanche);

        }
    }
}