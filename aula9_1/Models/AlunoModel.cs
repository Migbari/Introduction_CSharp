namespace Models
{
    public class AlunoModel
    {
        /// <summary>
            /// Nome do aluno
            /// </summary>
            /// <value>string</value>
            public string Nome {get; set;}

            /// <summary>
            /// Curso do aluno
            /// </summary>
            /// <value>string</value>
            public string Curso {get; set;}

            /// <summary>
            /// RA do aluno, identificação
            /// </summary>
            /// <value>string</value>
            public string RA {get; set;}

            /// <summary>
            /// Idade do aluno
            /// </summary>
            /// <value>int</value>  
            public int Idade {get; set;}
        }
        
        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar () {
            Console.Write ("Estou estudando!");
        }

        /// <summary>
        /// Pede café ao professor
        /// </summary>
        public void PedirIntervalo () {
            Console.WriteLine ("Pode fazer intervalo?");
            Console.WriteLine ("QUERO CAFÉ");
        }

        /// <summary>
        /// Pede ajuda ao professor 
        /// </summary>
        public void PedirAjuda () {
           Console.WriteLine("Ajuda aee Pauloo!");
        }
    }

