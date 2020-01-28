using System;

namespace aula8_1{
    class Program {
        static void Main (string[] args) {
            int numero;

            // Para tratar erro e não exibir para usuário
            try {
                // Escrevemos um bloco de código
                Console.WriteLine ("Digite um número");
                numero = int.Parse (Console.ReadLine ());

                // Exceção.  // A variável EX recebe e mostra o erro // Para não mostrar erro, exclui ex.
            } catch (Exception ex) {
                // Mostramos a exceção da regra.
                // Erro gerado na aplicação.
                Console.WriteLine ("Ops :( Algo de errado não está certo" + ex);
                // throw; = exibe o erro. 
            }
        }
    }
}