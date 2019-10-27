using System;
using System.Collections.Generic;

namespace aula13_1
{
    class Program
    {
        static void Main(string[] args)
        {   // Instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel(1, "Maça", "Verde", 3.5);

            // Chamamos um atributo do objeto instanciado. 
            Console.WriteLine(produto.NomeProduto);

            // Instanciamos nossa classe sem passar parâmetros utilizando sobrecarga 
            ProdutoModel produto_sobrecarga = new ProdutoModel();
            // Alimentamos nosso objeto (produto_sobrecarga) que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;

            Console.WriteLine(produto_sobrecarga.NomeProduto);

            // Chamamos a nossa lista que vai se do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribuídos em nossa lista
            prod.Add (new ProdutoModel (1, "Cenoura", "Laranja", 2.30) );
            prod.Add (new ProdutoModel (2, "Mamão", "Maduro", 2.30) );
            prod.Add (new ProdutoModel (3, "Banana", "Amarela", 3.40) );
            prod.Add (new ProdutoModel (4, "Abacate", "Verde", 3.33) );
            prod.Add (new ProdutoModel (5, "Beterraba", "Vinho", 5.20) );
            prod.Add (new ProdutoModel (6, "Jaca", "Azeda", 6.50) );

            // Lemos os dados 
            foreach(ProdutoModel p in prod){
                  Console.WriteLine(); 
                  Console.WriteLine(p.IdProduto); 
                  Console.WriteLine(p.NomeProduto); 
                  Console.WriteLine(p.Descricao); 
                  Console.WriteLine(p.Preco); 
                  Console.WriteLine(); 
            }
            // Chamos o NomeProduto índice 4 
            Console.WriteLine(prod[4].NomeProduto);
        }
    }
}
