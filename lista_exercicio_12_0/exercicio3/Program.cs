using System;
using exercicio3.Controllers;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produto = new ProdutoController();

           
            Console.Clear(); // Limpa a tela do terminal.

            produto.Produto();
            
            produto.Reserva();
        }
    }
}
