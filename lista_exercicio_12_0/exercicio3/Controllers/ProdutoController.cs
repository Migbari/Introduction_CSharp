using System;
using exercicio3.Models;

namespace exercicio3.Controllers {
    public class ProdutoController {

        int opcao; // Variável criada para receber entrada (1) ou (2) produto.
        ProdutoModel produto_model = new ProdutoModel ();
        public void Produto () {
            System.Console.WriteLine ("Insira o produto");
            Console.ReadLine ();

            System.Console.WriteLine ("Deseja Reservar?\n (1) SIM ou (2) NÃO");
            opcao = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Insira o produto");
            Console.ReadLine ();
            
            System.Console.WriteLine ("Deseja Reservar?\n (1) SIM ou (2) NÃO");
            opcao = int.Parse (Console.ReadLine ());
        }
        public void Reserva () {

            if (opcao == 1) {
                produto_model.Reserva = true;
            }
            if (produto_model.Reserva == true) {
                System.Console.WriteLine ("Produto Reservado");
            } else {
                System.Console.WriteLine ("Produto Disponível");
            }
        }
        

    }
}