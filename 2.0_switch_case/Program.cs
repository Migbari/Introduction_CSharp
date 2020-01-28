using System;

namespace aula5_1 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5]; // cria vetor nome tamanho 5
            string[] origem = new string[5]; // cria vetor origem tamanho 5
            string[] destino = new string[5]; // cria vetor destino tamanho 5
            DateTime[] data_ida = new DateTime[5]; // cria vetor data tamanho 5
            DateTime[] data_volta = new DateTime[5]; // cria vetor data tamanho 5

            string sair = "";

            while (sair != "0") {
                Console.WriteLine ("Bem vindo ao nosso sistema Passagens!");
                Console.WriteLine (
                    @"
                    Menu :                    
                    1 - Cadastrar
                    2 - Listar passagenes
                    0-Sair"); //@ Para quebrar linha

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                        for (int indice = 0; indice <= 4; indice++) {
                            Console.Write ("Entre como nome do passageiro: ");
                            nome[indice] = Console.ReadLine ();

                            Console.Write ("Digite a UF de origem: ");
                            origem[indice] = Console.ReadLine ();

                            Console.Write ("Digite a UF de destino: ");
                            destino[indice] = Console.ReadLine ();

                            Console.Write ("Digite a data de IDA: ");
                            data_ida[indice] = DateTime.Parse (Console.ReadLine ());

                            Console.Write ("Digite a data de VOLTA: ");
                            data_volta[indice] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso! :)");

                        }

                        break;

                    case "2":
                        for (int i = 0; i <= 4; i++) {
                            if (
                                nome[i] != "" &&
                                origem[i] != "" &&
                                destino[i] != "" &&
                                data_ida[i] != null &&
                                data_volta[i] != null) {

                                Console.WriteLine ();
                                Console.WriteLine ("Passagem Nº " + i + 1);

                                Console.WriteLine (nome[i]);
                                Console.WriteLine (origem[i]);
                                Console.WriteLine (destino[i]);
                                Console.WriteLine (data_ida[i]);
                                Console.WriteLine (data_volta[i]);
                                Console.WriteLine ();

                            }
                        }
                        break;

                        case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema! ;)" );
                        break;

                        default: 
                            Console.WriteLine("Entrada inválida");
                            break;

                }

            }

        }
    }
}