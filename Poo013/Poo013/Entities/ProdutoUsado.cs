using System.Globalization;

namespace Poo013.Entities
{
    internal class ProdutoUsado : Produto
    {
        //Atributo da Classe - Produto Usado
        DateTime DataFabricacao { get; set; }

        //Construtor da Classe - Produto Usado
        public ProdutoUsado(string nomeProduto, double preco, DateTime dataFabricacao) : base (nomeProduto, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        //Função da Classe - Etiqueta de Preço
        public override string EtiquetaDePreco()
        {
            return NomeProduto
                + " (usado) - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " - (data de fabricação: " + DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
