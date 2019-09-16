using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float despesas; 
            float resultado;

            Console.WriteLine("Digite o valor do salário: ");
            salario = float.Parse(Console.ReadLine() );

            Console.WriteLine("Digite o valor das despesas: ");
            despesas = float.Parse(Console.ReadLine() );

            resultado = salario-despesas;

            if (resultado > 0){
                Console.WriteLine("Valor positivo de "+resultado);
            }
            else{
                Console.WriteLine("Valor negativo de "+resultado);
            }
            
       }
    }
}
