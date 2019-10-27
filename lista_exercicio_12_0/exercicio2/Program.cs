using System;
using exercicio2.Controllers;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController cellphone = new CelularController();

            Console.Clear(); // Limpa a tela do terminal.

            cellphone.Ligado();
            
            cellphone.FazerLigacao();
            
        }
    }
}
