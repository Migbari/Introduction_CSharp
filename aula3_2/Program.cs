using System;

namespace aula3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAÇO CONDICIONAO - WHILE 

            double acumuladora = 0; // Será variável acumuladora 
            double nota = 0; // Receberá o valor - input
            int cont = 0; // iniciou  o contador com 0.
            string sair = ""; // 

            while (sair != "sim") { // Enquanto (sair diferente de SIM) // Condição para continuar
                Console.Write ("Digite a nota de umm aluno: "); // Leia nota do aluno
                nota = double.Parse (Console.ReadLine ());

                acumuladora = acumuladora + nota; // Ou acumuladora += nota // Para acumular nota defino uma variável 
                cont++; // 0u cont = cont + 1 // Terá a quantidade de giros. 
                // 5 numeros inseridos = 5 giros. 14 numeros inseridos = 14 giros.

                Console.Write ("Deseja sair da aplicação? sim/não "); // Leia sair para fechar aplicação
                sair = Console.ReadLine ().ToLower (); // Tolower - identificar letras minúsculo e maiúsculo 
            }

            Console.WriteLine ("Média das notas: " + (acumuladora / cont)); // Escreva acumuladora dividido por cont.
            // Cont possui a quantidadde de voltas dadas até que SAIR for digitado   
        }
    }
}
