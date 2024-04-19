using System;
using System.Globalization;

namespace Poo002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Funcionário
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            //Entrada de Dados - 1º Funcionário
            Console.WriteLine("Dados do 1º funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Entrada de Dados - 2º Funcionário
            Console.WriteLine("\nDados do 2º funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Resultado - Média Salarial
            double mediaSalarial = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("\nSalário médio: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
