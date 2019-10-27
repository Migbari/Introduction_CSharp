using System;

using lista_exercicio_12_0.Controllers;    
namespace lista_exercicio_12_0
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno1 = new AlunoController();
    
            aluno1.CadastrarAluno();
            System.Console.WriteLine();
            aluno1.ExibirAluno();
        }
    }
}
