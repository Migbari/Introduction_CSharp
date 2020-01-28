using System;

namespace aula9_2.Models
{
/// <summary>
    /// Modelo de Aluno.
    /// </summary>
    public class AlunoModel {

        
        /// <summary>
        /// Nome do aluno.
        /// </summary>
        /// <value>String.</value>
        public string Nome {get; set; }

        /// <summary>
        /// Nome do curso.
        /// </summary>
        /// <value>String.</value>
        public string Curso { get; set; }

        /// <summary>
        /// RG do aluno.
        /// </summary>
        /// <value>int</value>
        public double Rg { get; set; }

        /// <summary>
        /// Idade do aluno.
        /// </summary>
        /// <value>Int.</value>
        public int Idade { get; set; }

        /// <summary>
        /// Exibe as informações do aluno.
        /// </summary>
        public void ExibirAluno () {
            Console.WriteLine ("Nome: " + Nome);
            Console.WriteLine ("Curso: " + Curso);
            Console.WriteLine ("RG: " + Rg);
            System.Console.WriteLine ("Idade: " + Idade);
        }

        /// <summary>
        /// Método ir no banheiro, somente imprime uma string na tela.
        /// </summary>
        public void IrNoBanheiro () {
            System.Console.WriteLine ("=======================================");
            System.Console.WriteLine ("      Deixa eu ir no banheiro AEEE!!");
            System.Console.WriteLine ("=======================================");
        }

         /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar () {
            System.Console.WriteLine ("Estou estudando!");
        }

        /// <summary>
        /// Pede café ao professor
        /// </summary>
        public void PedirIntervalo () {
            System.Console.WriteLine ("Pode fazer intervalo?");
            System.Console.WriteLine ("QUERO CAFÉ");
        }

        /// <summary>
        /// Pede ajuda ao professor 
        /// </summary>
        public void PedirAjuda () {
            System.Console.WriteLine ("Ajuda aee Pauloo!");
        }
    }
}