using Poo013.Entities;
using System.Globalization;

//Entrada de Dados - Dados do Produto
Console.Write("Digite o número de produtos: ");
int nProd = int.Parse(Console.ReadLine());

//Declaração de Lista de Produtos
List<Produto> listaProdutos = new List<Produto>();

for (int i = 1; i <= nProd; i++)
{
    Console.WriteLine($"\nDados do #{i} produto: ");
    Console.Write("(P/U/I): ");
    char opcao = char.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nomeProd = Console.ReadLine();
    Console.Write("Preço: R$ ");
    double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (opcao == 'p' || opcao == 'P')
    {   
        //Instância de Obj. - Produto Padrão
        listaProdutos.Add(new Produto(nomeProd, precoProd));
    }
    else if (opcao == 'u' || opcao == 'U')
    {
        Console.Write("Data de fabricação: ");
        DateTime dataFab = DateTime.Parse(Console.ReadLine());

        //Instância de Obj. - Produto Usado
        listaProdutos.Add(new ProdutoUsado(nomeProd, precoProd, dataFab));
    }
    else
    {
        Console.Write("Taxa de alfândega: R$ ");
        double taxaAlf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Instância de Obj. - Produto Importado
        listaProdutos.Add(new ProdutoImportado(nomeProd, precoProd, taxaAlf));
    }
}

//Saída de Dados - Dados do Produto
Console.WriteLine("\nEtiqueta de Preços: ");

foreach (Produto prod in listaProdutos)
{
    Console.WriteLine(prod.EtiquetaDePreço());
}