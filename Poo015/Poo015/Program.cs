using Poo015.Entities;
using Poo015.Entities.Exceptions;
using System.Globalization;

//Entrada de Dados - Dados da Conta
Console.WriteLine("Digite os dados da conta: ");
Console.Write("Número da conta: ");
int numeroAcc = int.Parse(Console.ReadLine());
Console.Write("Titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Saldo inicial: R$ ");
double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Limite de saque: R$ ");
double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Instância de Obj. - Conta 
Conta conta = new Conta(numeroAcc, titular, saldo, limiteSaque);

//Validação de Possível Exceção - Saldo da Conta
try
{
    //Entrada de Dados - Atualização da Conta
    Console.Write("\nDigite um valor para saque: R$ ");
    double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta.Saque(saque);

    //Saída de Dados - Saldo Atualizado
    Console.WriteLine(conta);
}
catch (AccException exc)
{
    Console.WriteLine("Erro de saque: " + exc.Message);
}