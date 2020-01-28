using System;
using aula9_2.Models;

namespace aula9_2 {
    class Program {
        static void Main (string[] args) {
            //Declarando Objeto
            AlunoModel aluno1 = new AlunoModel (); // Declarando uma nova instância

            // Limpa a tela
            Console.Clear ();

            // Cadastra um aluno.
            aluno1.CadastrarAluno ();

            // Exibindo as informações
            aluno1.ExibirAluno ();

            // Chama método do objeto 'aluno1'
            aluno1.IrNoBanheiro ();

             // Chama método estudar
            aluno1.Estudar();

            // Chama método PedirIntervalo 'aluno1'
            aluno1.PedirIntervalo();

            // Chama método PedirAjuda 'aluno1'
            aluno1.PedirAjuda();



        }
    }
}