namespace aula11_1.Models
{
    public class ProdutosModel
    {
        public int IdProduto {get; set;} // Get e Set Permite manipular os atributos fora da Classe

        public string NomeProduto {get; set;} 
        
        public string Descricao {get; set;}  

        public double Preco {get; set;} 

        public FornecedoresModel Fornecedor {get; set;} // obj Fornecedor // Acessar os atributos de FornecedoresModel
        // Conceito de Composição // Fornecedor Criado para o Get e Set de FornecedoresModel
    }
}