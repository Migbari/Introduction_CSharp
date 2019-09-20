using System;

namespace aula3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int acumuladora = 0; // Inicie o primeiro valor do acumulador com 0. Acumulador será usado para somar dos múltiplos de 3 da variável número.
            int numero;

            do { // Faça 
                Console.WriteLine ("Digite um número"); // Escreva (Mensagem)
                numero = int.Parse (Console.ReadLine ());  // Leia um número - Variável recebe número inserido
                
                if (numero % 3 == 0){ // Se (numero dividido por 3 = resto = 0)
                acumuladora = acumuladora + numero; // Recebe numero + valor dentro de acumuladora que será número anterior
                } 

            } while (numero <= 100); // Enquanto menor ou igual a 100 execute condição acima.
          
          
            Console.WriteLine("A soma dos múltiplos de 3 são:"+acumuladora); // Escreve valor acumulado dos múltiplos de 3
        
        }
    }
}
