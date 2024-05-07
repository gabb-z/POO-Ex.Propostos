using System;
using System.Collections.Generic;
using Poo009;

//Entrada de Dados - Cadastro de Funcionários
Console.Write("Quantos funcionários deseja cadastrar: ");
int nFunc = int.Parse(Console.ReadLine());

//Declaração de Lista - Funcionário
List<Funcionario> listaFunc = new List<Funcionario>();

//Entrada de Dados - Dados do Funcionário
for (int i = 1; i <= nFunc; i++)
{
    Console.WriteLine("\nFuncionário(a) #" + i + ": ");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Salário: R$ ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    listaFunc.Add(new Funcionario(nome, id, salario));
}

//Entrada de Dados - Buscar ID
Console.Write("\nDigite o ID do(a) funcionário(a) que deseja aumentar o salário: ");
int buscarId = int.Parse(Console.ReadLine());

//Instância de Objeto para Filtro de Lista - Funcionário
Funcionario funcionario = listaFunc.Find(x => x.Id == buscarId);

//Condicional - Aumentar Salário
if (funcionario != null)
{
    Console.Write("Digite a porcentagem que deseja aumentar o salário do(a) funcionário(a) escolhido(a): ");
    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentarSalario(porcentagem);
}
else
{
    Console.WriteLine("\nO ID informado não existe!");
}

//Saída de Dados - Lista de Funcionários
Console.WriteLine("\nLista atualizada de funcionários: ");

foreach (Funcionario f in listaFunc)
{
    Console.WriteLine("\n" + f);
}