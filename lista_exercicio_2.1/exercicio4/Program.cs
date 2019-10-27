using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

        // Ao clicar no botão encomentar, indicamos a ação para logado ou não logado.     
        bool login = false;
        int entrada; 
        string retorno;

        Console.Write("opção 1, opção 2: ");
        entrada = int.Parse(Console.ReadLine() );

        if(entrada == 1){
            login = true;
        }
        if(login == true){
            retorno = "Página encomendar!";
        }
        else{
            retorno = "Página Cadastro/Login";
        }
        Console.WriteLine(retorno);
        
        }
    }
}
