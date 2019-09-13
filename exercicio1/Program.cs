using System;

namespace aula1exercicios
{
    class Program
    {
        static void Main(string[] args)

        {   //ex 1
            int valor;
            int resultado;

            //ex 2
            int custo;
            int venda;

            //ex 3
            int salario;
            int produtosvendidos;
            int retorno;
            int total;  

            //ex 4
            double real;
            double dolar;
            double conversao; 

            //Ex 5
            string nome;

            Console.WriteLine("Digite um número: ");
            valor = int.Parse(Console.ReadLine());

            resultado = valor*3;
            Console.WriteLine("Seu triplo é: " + resultado);  // end       
          
            //Exercício 2
            Console.WriteLine("Informe o custo");
            custo = int.Parse(Console.ReadLine());

            venda = (custo*40)/100;
            Console.WriteLine("O preço da venda é 40% a mais, ou seja: "+venda);  // end     

            //Exercício 3
            Console.WriteLine("Informe valor do salário: ");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em R$ sobre vendas: ");
            produtosvendidos = int.Parse(Console.ReadLine());

            retorno = (produtosvendidos*5)/100;

            total = retorno+salario;
            Console.WriteLine("Seu salári0 + comissão é: " +total); // end

            //Ex 4
            Console.WriteLine("Informe o valor em R$: ");
            real = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cotação U$: ");
            dolar = double.Parse(Console.ReadLine());

            conversao = real/dolar;
            Console.WriteLine("O valor em dólar é: " + conversao);  // end     
             
            // Ex4 5
            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o custo");
            custo = int.Parse(Console.ReadLine());

            venda = (custo*40)/100;
            Console.WriteLine("O preço da venda é 40% a mais, ou seja: "+venda);


        }

    }
}
