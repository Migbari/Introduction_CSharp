using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        bool login = false;
        int entrada; 
        string retorno;

        Console.Write("opção 1, opção 2: ");
        entrada = int.Parse(Console.ReadLine() );
        // Como atribuímos anteriormente, mudamos o estado da variável para verdadeira 
        // caso entre nessa condição. 

        if(entrada == 1){
            login = true;
        }
        if(login == true){
            retorno = "Usuário logado!";
        }
        else{
            retorno = "Usuário não logado";
        }
        Console.WriteLine(retorno);
            
        }
    }
}
