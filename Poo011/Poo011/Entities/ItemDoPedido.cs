using System.Globalization;

namespace Poo011.Entities
{
    internal class ItemDoPedido
    {
        //Atributos da Classe - Dados do Item do Pedido
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        //Associação de Tipo - Produto
        public Produto Produto { get; set; }

        //Construtor da Classe - Dados do Item do Pedido
        public ItemDoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        //Função da Classe - Subtotal do Pedido
        public double Subtotal()
        {
            return Preco * Quantidade;
        }

        //Override ToString - Dados do Produto
        public override string ToString()
        {
            return Produto.NomeProduto
                + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: R$ "
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
