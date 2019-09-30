using System;
using lista_exercicio_11;
using lista_exercicio_11_Models;

namespace lista_exercicio_11_Controllers
{
    public class PessoaController
    {           
        PessoaModel pessoa = new PessoaModel ();

        public void CadastrarPessoa(){

            System.Console.WriteLine("Digite o nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine() );

            System.Console.WriteLine("Digite o peso: ");
            pessoa.Peso = Double.Parse(Console.ReadLine() );

            System.Console.WriteLine("Digite a altura: ");
            pessoa.Altura = Double.Parse(Console.ReadLine() );
        }
        public void ExibirPessoa(){
            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa.Idade);
            System.Console.WriteLine(pessoa.Peso);
            System.Console.WriteLine(pessoa.Altura);
        }
        public void CalcularImc(){
            double peso;
            double altura;
            double imc;

            System.Console.WriteLine("Digite o peso: ");
            peso = Double.Parse(Console.ReadLine() );

            System.Console.WriteLine("Digite a altura: ");
            altura = Double.Parse(Console.ReadLine() );

            imc = 
        }
                
    }
}