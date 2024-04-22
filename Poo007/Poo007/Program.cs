using System;
using System.Globalization;

namespace Poo007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Conta Bancária
            ContaBancaria conta = new ContaBancaria();

            //Entrada de Dados - Dados do Titular
            Console.Write("Digite o nº da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do(a) titular da conta: ");
            string nomeTitular = Console.ReadLine();

            //Entrada de Dados - Haverá Depósito Inicial?
            Console.Write("Deseja realizar um depósito inicial? (s/n): ");
            char opcao = char.Parse(Console.ReadLine());

            //Condicional - Depósito Inicial
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: R$ ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nConta, nomeTitular, depInicial);
            }
            else
            {
                conta = new ContaBancaria(nConta, nomeTitular);
            }

            //Saída de Dados - Criacação de Conta
            Console.WriteLine("\nDado(s) da conta: " + conta);

            //Entrada de Dados - Realizar Depósito
            Console.Write("\nDigite um valor para depósito: R$ ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            //Saída de Dados - Atualizado
            Console.WriteLine("\nDado(s) da conta atualizado(s): " + conta);

            //Entrada de Dados - Realizar Saque
            Console.Write("\nDigite um valor para saque: R$ ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            //Saída de Dados - Atualizado
            Console.WriteLine("\nDado(s) atualizado(s): " + conta);
        }
    }
}
