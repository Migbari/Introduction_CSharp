using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           //ex 5
            int salario;
            int produtosvendidos;
            int retorno;
            int total;
            string nome;

            //Exercício 5
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();        

            Console.WriteLine("Informe valor do salário: ");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em R$ sobre vendas: ");
            produtosvendidos = int.Parse(Console.ReadLine());

            retorno = (produtosvendidos*10)/100;

            total = retorno+salario;
            Console.WriteLine("Bom dia!!"+nome);
            Console.WriteLine("Seu salári0 é: "+salario);   
            Console.WriteLine("Sua comissão é de:" +retorno);
            Console.WriteLine("Valor final: "+total); // end

        }
    }
}
