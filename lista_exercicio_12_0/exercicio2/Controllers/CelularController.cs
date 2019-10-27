using exercicio2.Models;

namespace exercicio2.Controllers {
    public class CelularController {
        CelularModel celular = new CelularModel ();

        public void Ligado () {
            celular.Ligado = true;
            System.Console.WriteLine ("Celular Ligado! ");
        }
        public void Desligado () {
            celular.Ligado = false;
            System.Console.WriteLine ("Celular Desligado");
        }
        public void FazerLigacao () {
            if (celular.Ligado == true) {
                System.Console.WriteLine ("Efetuando ligação...");
            } else {
                System.Console.WriteLine ("Celular Desligado: Ligue o celular Abestado");
            }
        }
        public void EnviarMensagem () {
            if (celular.Ligado == true) {
                System.Console.WriteLine ("Enviando mensagem...");
            } else {
                System.Console.WriteLine ("Celular Desligado: Ligue o celular Abestado");
            }
        }




        

    }

}

