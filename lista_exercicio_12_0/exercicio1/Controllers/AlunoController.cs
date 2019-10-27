using System;
using lista_exercicio_12_0.Models;

namespace lista_exercicio_12_0.Controllers {
    public class AlunoController {

        int retorno;
        AlunoModel aluno = new AlunoModel (); // Instanciando Classe AlunoModel para obter Gets e Sets  
        public void CadastrarAluno () { // Criando método para cadastrar aluno

            Console.WriteLine ("Digite o Nome do Aluno: ");
            aluno.Nome = Console.ReadLine ();

            Console.WriteLine ("Digite o Curso do Aluno: ");
            aluno.Curso = Console.ReadLine ();

            Console.WriteLine ("Digite a Idade do Aluno: ");
            aluno.Idade = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o Rg do Aluno: ");
            aluno.Rg = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite se o Aluno é Bolsista: \n(1) Para Sim e (2) Não): ");
            retorno = int.Parse (Console.ReadLine ());

            if (retorno == 1){
                aluno.bolsista = true;
            }
            if (aluno.bolsista == true){
                Console.WriteLine("Aluno Bolsista");
            }else{
                Console.WriteLine("Não Bolsista");
            }
        }

        public void ExibirAluno () {
            System.Console.WriteLine (aluno.Nome);
            System.Console.WriteLine (aluno.Curso);
            System.Console.WriteLine (aluno.Idade);
            System.Console.WriteLine (aluno.Rg);
            

        }
    }
} // Efetuar correção deste...