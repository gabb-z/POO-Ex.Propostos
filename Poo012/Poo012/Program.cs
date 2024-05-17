using Poo012.Entities;
using System.Globalization;

//Entrada de Dados - Dados do Funcionário
Console.Write("Digite o número de funcionários: ");
int nFuncionarios = int.Parse(Console.ReadLine());

//Declaração de Lista de Funcionários
List<Funcionario> listaFunc = new List<Funcionario>();

for (int i = 1; i <= nFuncionarios; i++)
{
    Console.WriteLine($"\nDados do #{i} funcionário: ");
    Console.Write("Terceirizado? (s/n): ");
    char opcao = char.Parse(Console.ReadLine());
    Console.Write("Nome do funcionário: ");
    string nomeFunc = Console.ReadLine();
    Console.Write("Horas trabalhadas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("Valor por hora: R$ ");
    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (opcao == 's' || opcao == 'S')
    {
        Console.Write("Despesa adicional: R$ ");
        double despesaAdd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Instância de Obj. na Lista - Funcionário Terceirizado
        listaFunc.Add(new FuncionarioTerceirizado(nomeFunc, horas, valorHora, despesaAdd));
    }
    else
    {
        //Instância de Obj. na Lista - Funcionário
        listaFunc.Add(new Funcionario(nomeFunc, horas, valorHora));
    }
}

//Saída de Dados - Dados dos Funcionários
Console.WriteLine("\nPagamentos: ");
foreach (Funcionario func in listaFunc)
{
    Console.WriteLine(func.NomeFunc + " - R$ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
}
