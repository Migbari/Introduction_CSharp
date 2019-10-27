using System;
using aula12_1.Controllers;
using aula12_1.Models;

namespace aula12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarrosEletricosController carroEletrico = new CarrosEletricosController();

            Console.Clear(); // Limpa a tela do terminal.

            carroEletrico.Ligar();

            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());

        }
    }
}
