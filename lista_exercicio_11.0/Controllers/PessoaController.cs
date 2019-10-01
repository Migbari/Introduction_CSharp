using System;
using System.IO;
using lista_exercicio_11;
using lista_exercicio_11_Models;

namespace lista_exercicio_11_Controllers {
    public class PessoaController {
        PessoaModel pessoa = new PessoaModel ();

        public void CadastrarPessoa () {

            try
            {   // Para tratar erro caso usuário digite erroneamente outro tipo de caracter
            System.Console.WriteLine ("Digite o nome da pessoa: ");
            pessoa.Nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite a idade: ");
            pessoa.Idade = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o peso: ");
            pessoa.Peso = Double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite a altura: ");
            pessoa.Altura = Double.Parse (Console.ReadLine ());
            }
            
            catch (Exception ex){ // variável ex do tipo Exception irá salvar erro
                System.Console.WriteLine ("Desculpe :( Houve um erro na aplicação: ");
                SalvarErros (ex);
            }

        }
        public void ExibirPessoa () {
            System.Console.WriteLine (pessoa.Nome);
            System.Console.WriteLine (pessoa.Idade);
            System.Console.WriteLine (pessoa.Peso);
            System.Console.WriteLine (pessoa.Altura);
        }
        public void CalcularImc () {

            double imc;

            imc = pessoa.Peso / Math.Pow (pessoa.Altura, 2);

            if (imc < 18.5) {
                System.Console.WriteLine ("Abaixo do Peso");
            } else if (imc >= 18.5 && imc <= 25) {
                System.Console.WriteLine ("Peso Normal");
            } else if (imc >= 26 && imc <= 30) {
                System.Console.WriteLine ("Sobrepeso");
            } else if (imc >= 31 && imc <= 35) {
                System.Console.WriteLine ("Obesidade Grau I");
            } else if (imc >= 36 && imc <= 39) {
                System.Console.WriteLine ("Obesidade Grau II");
            } else if(imc >= 40){
                System.Console.WriteLine("Obesidade Grau III");
            } else{
                System.Console.WriteLine("");
            }
            System.Console.WriteLine (imc);
        }

        private void SalvarErros (Exception ex) { 
            // Cria e nomeia arquivo que guardará os erros 
            // True para adicionar nas proximas linhas os logs de erros
            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ()); // Data escrita 
            txt.WriteLine (DateTime.Now.ToShortDateString ()); // Data apenas números 
            txt.WriteLine (ex); // Mostrar o erro
            txt.WriteLine (); // Apenas para quebra da linha

            txt.Close (); // Salva automaticamente ao fechar
        }

    }
}