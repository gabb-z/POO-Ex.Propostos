using System;
using System.Globalization;

namespace Poo004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Funcionário
            Funcionario func = new Funcionario();

            //Entrada de Dados - Dados do Funcionário 
            Console.WriteLine("Digite o(s) dado(s) do(a) funcionário(a): ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: R$ ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$ ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Dados do Funcionário
            Console.WriteLine("\nDado(s) do(a) funcionário(a): " + func);

            //Entrada de Dados - Aum. Salário
            Console.Write("\nDigite a porcentagem que deseja aumentara o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            //Dados do Funcionário - Atualizados
            Console.WriteLine("\nDado(s) atualizado(s): " + func);
        }
    }
}
