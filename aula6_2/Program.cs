using System;

namespace aula6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine(ValidaCPF(cpf) );
            //Ref: https://laennder.com/como-e-feito-o-calculo-de-validacao-cpf/
        }

        static bool ValidaCPF (string cpfUsuario){ // static

            bool resultado = false; 
            int [] v1 = {10, 9, 8, 7, 6, 5, 4, 3, 2}; // vetor com 8 indices a partir de 0. 

            string cpfCalculo = ""; 
            int resto = 0; // variavel para receber resto da divisão
            int calculo = 0; 

            string digito_v1 = ""; // vetor para primeiro digito veriicador
            string digito_v2 = ""; // vetor para segundo digito verificador
       
            cpfUsuario = cpfUsuario.Replace(" ","");  // Para tratar o ""/ não considera
            cpfUsuario = cpfUsuario.Replace("-","");  // Para tratar o - / não considera
            cpfUsuario = cpfUsuario.Replace(".","");  // Para tratar o . / não considera
            
            
            cpfCalculo = cpfUsuario.Substring(0, 9);  //Substring pega os caracteres de uma string
            // sendo 0 para indicar o indice e 9 a quantidade de caracteres para pegar

            for(int i = 0; i <= 8; i++){ 
                calculo += int.Parse(cpfCalculo[i].ToString()) * v1[i];
            } 

            resto = calculo % 11; //  resto de calculo dividido por 11
            calculo = 11 - resto;

            if (calculo > 9){
                digito_v1 = "0";
            }else{
                digito_v1 = calculo.ToString();
            }

            if (digito_v1 == cpfUsuario[9].ToString() ){
                resultado = true;
            }



            int[] v2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            resto = 0;
            calculo = 0;

            cpfCalculo = cpfCalculo+calculo;    
            calculo = 0;   

             for(int i = 0; i <= 9; i++){
                calculo += int.Parse(cpfCalculo[i].ToString()) * v2[i];
            } 

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9){
                digito_v2 = "0";
            }else{
                digito_v2 = calculo.ToString();
            }

            if (digito_v2 == cpfUsuario[10].ToString() ){
                resultado = true;
            }

            return resultado;

        }
    }
}
