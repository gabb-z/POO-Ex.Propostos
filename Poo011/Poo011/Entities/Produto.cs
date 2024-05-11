namespace Poo011.Entities
{
    internal class Produto
    {
        //Atributos da Classe - Dados do Produto
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }

        //Construtor da Classe - Dados do Produto
        public Produto(string nomeProduto, double precoProduto)
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
        }
    }
}
