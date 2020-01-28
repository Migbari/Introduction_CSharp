namespace aula13_1
{
    public class ProdutoModel
    {
        public int IdProduto {get; set;}
        public string NomeProduto {get; set;}
        public string Descricao {get; set;}
        public double Preco {get; set;}

        

        // Construtor com a instancia para atribuir os valores
        public ProdutoModel (int idproduto, string nomeproduto, string descricao, double preco){

            this.IdProduto = idproduto; 
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco; 
        }

        // Utilizamos sobrecarga para poder instanciar passando ou não os atributos/parâmetros
        // Método construtor para utilização da sobrecarga. 
        public ProdutoModel(){

        }
    }
}