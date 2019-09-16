using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos as notas que utilizaremos
            double nota1, nota2, nota3, media;

            // Capturamos a primeira nota
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine() );

            // Capturamos a segunda nota
            Console.Write("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine() );

            // Capturamos a terceira nota
            Console.Write("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine() );

            media = (nota1 + nota2 + nota3) / 3;

            //Verificamos se a média do aluno é maior ou igual a 6
            if (media >= 6){   
                Console.WriteLine($"Média: {media} Aluno aprovado!");
                }
            else {
                Console.WriteLine($"Média: {media} Aluno reprovado!");
                }

        }
    }
}
