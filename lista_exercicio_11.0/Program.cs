using System;
using lista_exercicio_11_Controllers;

namespace lista_exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaController pessoa1 = new PessoaController();

           pessoa1.CadastrarPessoa();
           pessoa1.ExibirPessoa();
           pessoa1.CalcularImc();

        }   
    }
}
