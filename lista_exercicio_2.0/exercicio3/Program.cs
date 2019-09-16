using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1;
           int num2;

           Console.WriteLine("Digite o primeiro número: ");
           num1 = int.Parse(Console.ReadLine() );

           Console.WriteLine("Digite o segundo número: ");
           num2 = int.Parse(Console.ReadLine() );

            if (num1>num2){
                Console.WriteLine("O primeiro número é maior");
            }
            else{
                Console.WriteLine("O primeiro número é menor");
            }
           
        }
    }
}
