using System;
using System.Globalization;
using Poo010.Entities;
using Poo010.Entities.Enums;

//Entrada de Dados - Depto. do Funcionário
Console.Write("Digite o departamento do funcionário: ");
string dep = Console.ReadLine();

//Entrada de Dados - Dados do Funcionário
Console.WriteLine("\nDigite os dados do funcionário: ");
Console.Write("Nome: ");
string nomeFunc = Console.ReadLine();
Console.Write("Nível do funcionário (Júnior / Pleno / Sênior): ");
NivelFuncionario nivelFunc = Enum.Parse<NivelFuncionario>(Console.ReadLine()); 
Console.Write("Salário base do funcionário: R$ ");
double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Instância de Obj. - Departamento & Funcionário
Departamento departamento = new Departamento(dep);
Funcionario funcionario = new Funcionario(nomeFunc, nivelFunc, salarioBase, departamento);

//Entrada de Dados - Contratos do Funcionário
Console.Write("\nQuantos contratos deseja adicionar para esse funcionário: ");
int nContratos = int.Parse(Console.ReadLine());

for (int i = 1; i <= nContratos; i++)
{
    Console.WriteLine($"\nDigite os dados do #{i} contrato: ");
    Console.Write("Data do contrato (DD/MM/AAAA): ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora do contrato: ");
    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração do contrato (horas): ");
    int duracao = int.Parse(Console.ReadLine());

    //Instância de Obj. - Contrato
    ContratoHora contrato = new ContratoHora(data, valorHora, duracao);
    funcionario.AddContrato(contrato);
}

//Entrada de Dados - Cálculo do Contrato
Console.Write("\nDigite o mês e ano dos quais deseja consultar os ganhos do funcionário (MM/AAAA): ");
string mesAno = Console.ReadLine();
int mes = int.Parse(mesAno.Substring(0, 2));
int ano = int.Parse(mesAno.Substring(3));

//Saída de Dados - Dados do Funcionário
Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.Departamento.NomeDepto);
Console.WriteLine($"Ganhos da data {mesAno}: R$ " + funcionario.GanhoTotal(ano, mes).ToString("F2", CultureInfo.InvariantCulture));