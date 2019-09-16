using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 6
            float passageiros;
            float passagem;
            float total;

            //Exercício 6
            Console.WriteLine("Quantidade de passageiros: ");
            passageiros = int.Parse(Console.ReadLine());        

            Console.WriteLine("Valor da passagem: ");
            passagem = float.Parse(Console.ReadLine());

            total = passageiros*passagem;

            Console.WriteLine("O total de passageiros é de:"+passageiros);
            Console.WriteLine("Total de passagem: "+total);  // end
            
        }
    }
}
