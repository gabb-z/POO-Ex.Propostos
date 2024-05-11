using Poo011.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Poo011.Entities
{
    internal class Pedido
    {
        //Atributos da Classe - Dados do Pedido
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public StatusPedido Status { get; set; }

        //Associação de Tipos - Cliente & Item do Pedido
        public Cliente Cliente { get; set; }
        List<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();

        //Construtor da Classe - Dados do Cliente & Pedido
        public Pedido(DateTime dataPedido, StatusPedido status, Cliente cliente)
        {
            DataPedido = dataPedido;
            Status = status;
            Cliente = cliente;
        }

        //Função da Classe - Adicionar Item
        public void AddItem(ItemDoPedido item)
        {
            Itens.Add(item);
        }

        //Função da Classe - Remover Item
        public void RemoverItem(ItemDoPedido item)
        {
            Itens.Remove(item);
        }

        //Função da Classe - Valor Total do Pedido
        public double Total()
        {
            double soma = 0;

            foreach (ItemDoPedido item in Itens)
            {
                soma += item.Subtotal();
            }

            return soma;
        }

        //StringBuilder - Dados do Pedido
        public override string ToString()
        {
            StringBuilder prodString = new StringBuilder();

            prodString.AppendLine("Data do pedido: " + DataPedido.ToString());
            prodString.AppendLine("Status do pedido: " +  Status.ToString());
            prodString.AppendLine("\nDados do cliente: " +  Cliente.ToString());
            prodString.AppendLine("\nItens do pedido: ");

            foreach (ItemDoPedido item in Itens)
            {
                prodString.AppendLine(item.ToString());
            }

            prodString.AppendLine("\nValor total do pedido: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return prodString.ToString();
        }

    }
}
