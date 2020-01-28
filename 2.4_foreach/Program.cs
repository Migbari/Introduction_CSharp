using System;

namespace aula7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] v1 = {"A", "B", "C"};

            // Laço FOREACH (para cada) // Apenas mostra os elementos do vetor, sem necessidade de possuir variável contadora.
            foreach (string xpto in v1)
            {
                Console.WriteLine(xpto);
            }
        }
    }
}
