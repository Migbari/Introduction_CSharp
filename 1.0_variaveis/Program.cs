using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Variável é um espaço reservado para guardar um valor

           //Somente declaramos, sem atribuir valor
            int numero; 
            //Declaramos atribuindo um valor
            int numero2 = 5;

            //Declaramos diversas variáveis de mesmo tipo
            int num3, num4, num5;

            // Variável do tipo decimal (real)
            float media; 

            // Variável do tipo lógico (booleana)
            bool resultado = false; 
        
            string nomeAluno; 
            // Quebra linha
            Console.WriteLine();

            // Escreve em uma linha quebrando-a
            Console.WriteLine("Bem vindos a nossa primeira aplicação");

            // Continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" Seu nome");
            
            nomeAluno = Console.ReadLine();
            // Concatenação 
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota: ");
            // Capturo o dado difitado pelo usuário e salvo na variável

            // Converto o texto capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());

            // Interpolação/ Unir variável com txt
            Console.WriteLine($"Sua primeira nota é {num3} ");

            Console.WriteLine("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3+num4+num5)/3;

            //Console.WriteLine($"Sua média é {media} ");
            Console.WriteLine("Sua média é:" + media);

           

        }
    }
}