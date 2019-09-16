using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float compra;
            float resultado;

            Console.WriteLine("Digite o valor da compra: ");
            compra = float.Parse(Console.ReadLine() );

            resultado = compra-25;
                       
            if (compra > 100){ //Alterado para maior
                Console.WriteLine("Subtrair R$ 25,00 fica: "+resultado);
            }
            else{
                Console.WriteLine("Valor da compra é de: "+compra);
            }


        }
    }
}
