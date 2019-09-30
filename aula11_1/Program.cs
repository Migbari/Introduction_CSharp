using System;
using aula11_1.Controllers;

namespace aula11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto(); // Chamamos o método
            produto1.ExibirProduto(); // Chamamos o método
            

        }
    }
}
