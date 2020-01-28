using System;
using System.IO;
using aula11_1.Models;

namespace aula11_1.Controllers {
    public class ProdutosController {
        ProdutosModel produto = new ProdutosModel ();
        public void CadastrarProduto () { // Criando o método CadastrarProduto com Função CadastrarProduto

            try {
                Console.WriteLine ("Digite o ID do Produto: "); // cw atalho para ConsoleWriteLine
                produto.IdProduto = int.Parse (Console.ReadLine ()); // cr atalho para ConsoleReadLine

                System.Console.WriteLine ("Digite o nome do Produto: ");
                produto.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Digite a Descrição do Produto:");
                produto.Descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o Preço do Produto: ");
                produto.Preco = Double.Parse (Console.ReadLine ());

            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação: ");
                SalvarErros (ex); // 
            }

        }
        public void ExibirProduto () { // Criando método ExibirProduto com FunçãoExibirPrduto
            // Como o método CadastrarProduto irá possuir os dados, este novo método apenas irá exibir na tela
            System.Console.WriteLine (produto.IdProduto);
            System.Console.WriteLine (produto.NomeProduto);
            System.Console.WriteLine (produto.Descricao);
            System.Console.WriteLine (produto.Preco);
        }
        // Private, apenas será acessado neste arquivo
        private void SalvarErros (Exception ex) {
            // Cria e nomeia arquivo que guardará os erros 
            // True para adicionar nas proximas linhas os logs de erros
            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ()); //
            txt.WriteLine (DateTime.Now.ToShortDateString ());
            txt.WriteLine (ex); // Mostrar o erro
            txt.WriteLine (); // Apenas para quebra da linha

            txt.Close (); // Salva automaticamente ao fechar
        }

    }
}