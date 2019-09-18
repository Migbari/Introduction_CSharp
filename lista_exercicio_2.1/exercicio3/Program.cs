using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcao;
            string resultado;
            string email, senha, nomeCliente, dataNascimento;
            int cpf, cep;

            Console.WriteLine("Digitar 1 para Cliente e 2 para Fornecedor");
            opcao = int.Parse(Console.ReadLine() );
            
            if(opcao == 1){
                resultado = "Cliente";
            } else if (opcao == 2){
                resultado = "Fornecedor";
            } else {
                resultado = "Opção Inválida";
            }
            Console.WriteLine(resultado);


            if (opcao ==1){
            Console.WriteLine("Cliente / Insira seu email");
            email = Console.ReadLine();

            Console.WriteLine(" Cliente / Insira sua senha");
            senha = Console.ReadLine();

            Console.WriteLine(" Cliente / Insira seu cpf");
            cpf = int.Parse (Console.ReadLine()); 
            } 
                        
            else {
            Console.WriteLine(" Fornecedor / Insira seu nome completo");
            nomeCliente  = Console.ReadLine();

            Console.WriteLine(" Fornecedor / Insira sua data de nascimento");
            dataNascimento = Console.ReadLine();

            Console.WriteLine(" Fornecedor / CEP");
            cep = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(resultado+": cadastrado com sucesso");
             
        }
    }
}
