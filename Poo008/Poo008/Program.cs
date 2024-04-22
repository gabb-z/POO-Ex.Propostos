using Poo008;
using System;

Console.Write("Digite o número de quartos que deseja alugar: ");
int alugarQuartos = int.Parse(Console.ReadLine());

//Vetor - Nº de Quartos Disponíveis
QuartoAluno[] quartos = new QuartoAluno[10];

//Entrada de Dados - Dados do Aluno
for (int i = 1; i <= alugarQuartos; i++)
{
    Console.WriteLine("\nAluguel #" + i + ": ");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto escolhido: ");
    int quartoEscolhido = int.Parse(Console.ReadLine());

    quartos[quartoEscolhido] = new QuartoAluno(nome, email);
}

//Saída de Dados - Quartos Alugados & Disponíveis
Console.WriteLine("\nAlugados & Disponíveis: ");

for (int i = 0; i < 10; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine("Nº 0" + i + ": Ocupado - " + quartos[i].NomeAluno + ", " + quartos[i].EmailAluno);
    }
    else
    {
        Console.WriteLine("Nº 0" + i + ": Disponível");
    }
}