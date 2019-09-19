using System;

namespace aula3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int acumuladora = 0;
            int numero;

            do { // Faça 
                Console.WriteLine ("Digite um número"); // Leia um número - Variável recebe número inserido
                numero = int.Parse (Console.ReadLine ());
                
                if (numero % 3 == 0){
                acumuladora = acumuladora + numero; // Recebe numero + valor dentro de acumuladora que será número anterior
                cont = cont + 1; // Os giros
                } 

            } while (numero <= 100); // Enquanto for diferente de 0
          
          
            Console.WriteLine("A soma dos múltiplos de 3 são:"+acumuladora); // Escreve valor acumulado 
        }
    }
}
