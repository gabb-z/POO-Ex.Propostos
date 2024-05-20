using System.Globalization;

namespace Poo013.Entities
{
    internal class Produto
    {
        //Atributos da Classe - Dados do Produto
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        //Construtor da Classe - Dados do Produto
        public Produto(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }

        //Função da Classe - Etiqueta de Preço
        public virtual string EtiquetaDePreco()
        {
            return NomeProduto + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
