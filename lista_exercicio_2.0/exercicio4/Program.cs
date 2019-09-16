using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorpago;
            float resultado;
            float desconto;

            Console.WriteLine("Informe o valor a ser pago: ");
            valorpago = float.Parse(Console.ReadLine() );

            resultado = (valorpago*15) /100;
            desconto = valorpago-resultado;

            if(valorpago >= 100 && valorpago <= 1000){
              Console.Write("Valor a ser pago é: " +desconto);
            }
            else{
                Console.Write("Você não possui desconto:");        
            }
            
        }
    }
}
