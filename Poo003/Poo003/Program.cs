using System;
using System.Globalization;

namespace Poo003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Produto
            Produto prod = new Produto();

            //Entrada de Dados - Produto
            Console.WriteLine("Digite o(s) dado(s) do(s) produto(s): ");
            Console.Write("\nNome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: R$ ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            //Dados do Produto
            Console.WriteLine("\nDado(s) do(s) produto(s): " + prod);

            //Entrada de Dados - Add. Produtos ao Estoque
            Console.Write("\nDigite o número de produto(s) à ser(em) adicionado(s) em estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            prod.AddProduto(qtde);

            //Dados do Produto - Atualizados com Add.
            Console.WriteLine("\nDado(s) atualizado(s): " + prod);

            //Entrada de Dados - Remov. Produtos do Estoque
            Console.Write("\nDigite o número de produto(s) à ser(em) removido(s) do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            prod.RemovProduto(qtde);

            //Dados do Produto - Atualizados com Remov.
            Console.Write("\nDado(s) atualizado(s): " + prod);
        }
    }
}
