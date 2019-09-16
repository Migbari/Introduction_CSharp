using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 7
            int passageiros;
            float passagem;
            float total;

            //Exercício 7
            Console.WriteLine("Quantidade de passageiros: ");
            passageiros = int.Parse(Console.ReadLine());        

            Console.WriteLine("Valor da passagem: ");
            passagem = float.Parse(Console.ReadLine());

            total = passageiros*4.30f;

            Console.WriteLine("O total de passageiros é de:"+passageiros);
            Console.WriteLine("Total de passagem: "+total);  // end

        }
    }
}
