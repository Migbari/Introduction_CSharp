using System;

namespace aula6_1 {
    class Program {
        static void Main (string[] args) { // Chamamos nossa 1ª função
            Console.WriteLine (BomDia ());
            // Chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora ();
            // Chamamos nossa função que calcula a média
            double[] numeros = { 2, 5, 2, 8, 9, 5 };
            Console.WriteLine (CalculaMedia (numeros));
            // Chamamos a função de soma
            double[] valor = { 2, 5, 2, 1, 5 };
            Console.WriteLine (CalculaSoma (valor));
        }

        /// <summary>
        /// Função que escreve Bom Dia para o usuário
        /// </summary>
        /// <returns>Retorna Ola! Bom dia!</returns>
        static string BomDia () {
            return "Olá! Bom dia!";
        }

        /// <summary>
        /// Funçao que mostra ua saudação de acordo com  horário atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>
        static string BomDia (string saudacao) {

            int hora = DateTime.Now.Hour;

            if (hora <= 12 && hora >= 6) {
                saudacao = "Bom dia";
            } else if (hora > 12 && hora <= 18) {
                saudacao = "Boa tarde";
            } else {
                saudacao = "Boa noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// Retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }
        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia (double[] valores) {

            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            } //Quando não definimos o tamanho do vetor, Faremos a contagem com Length
            resultado = resultado / valores.Length;

            return resultado;

        }
        /// <summary>
        /// Função que calcula a soma de um vetor
        /// </summary>
        /// <param name="valor">Vetor com valores</param>
        /// <returns>Soma dos valores</returns>
        static double CalculaSoma (double[] valor) {

            double soma = 0;    

            for (int i = 0; i < valor.Length; i++) { 
                soma += valor[i]; 
            }
            return soma;
        }
    }
}