using System.Globalization;

namespace Poo013.Entities
{
    internal class ProdutoImportado : Produto
    {
        //Atributo da Classe - Produto Importado
        public double TaxaAlfandega { get; set; }

        //Construtor da Classe - Produto Importado
        public ProdutoImportado(string nomeProduto, double preco, double taxaAlfandega) : base(nomeProduto, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        //Função da Classe - Etiqueta de Preço
        public override string EtiquetaDePreço()
        {
            return NomeProduto 
                + " - R$ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) 
                + " - (taxa da alfândega: R$ " + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        //Função da Classe - Preço Total do Produto
        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }
    }
}
