using Poo014.Entities;
using System.Globalization;

//Entrada de Dados - Dados do Contribuinte
Console.Write("Digite o número de contribuintes: ");
int nContribuintes = int.Parse(Console.ReadLine());

//Declaração de Lista de Contribuintes
List<Contribuintes> listaContribuintes = new List<Contribuintes>();

for (int i = 1; i <= nContribuintes; i++)
{
    Console.WriteLine($"\nDados do #{i} contribuinte: ");
    Console.Write("Pessoa Física ou Pessoa Jurídica (f/j): ");
    char opcao = char.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Renda anual: R$ ");
    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (opcao == 'f' || opcao == 'F')
    {
        Console.Write("Gastos com saúde: R$ ");
        double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Instância de Obj. - Pessoa Física
        listaContribuintes.Add(new PessoaFisica(nome, renda, gastos));
    }
    else if (opcao == 'j' || opcao == 'J')
    {
        Console.Write("Quantidade de funcionários: ");
        int qtdFunc = int.Parse(Console.ReadLine());

        //Instância de Obj. - Pessoa Jurídica
        listaContribuintes.Add(new PessoaJuridica(nome, renda, qtdFunc));
    }

}

//Saída de Dados - Impostos Totais Pagos
Console.WriteLine("\nIMPOSTOS PAGOS: ");

foreach (Contribuintes cont in listaContribuintes)
{
    Console.WriteLine(cont);
}

Console.WriteLine("\nTOTAL DE IMPOSTOS: ");

double soma = 0;

foreach (Contribuintes cont in listaContribuintes)
{
    soma += cont.Imposto();
}

Console.WriteLine("R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));