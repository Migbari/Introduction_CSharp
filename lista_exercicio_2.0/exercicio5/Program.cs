using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número");
            num1 = int.Parse(Console.ReadLine() );

            Console.WriteLine("Digite o segundo número");
            num2 = int.Parse(Console.ReadLine() );

            Console.WriteLine("Digite o terceiro número");
            num3 = int.Parse(Console.ReadLine() );

            if(num1>num2 && num1>num3){
                Console.WriteLine("Numero 1 maior");
            }
            else if(num2>num1 && num2>num3){
                Console.WriteLine("Numero 2 maior");
            }
            else{
                Console.WriteLine("Numero 3 maior");
            }
        }
    }
}
