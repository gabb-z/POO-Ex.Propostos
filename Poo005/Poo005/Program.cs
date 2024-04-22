using System;
using System.Globalization;

namespace Poo005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Aluno
            Aluno aluno = new Aluno();

            //Entrada de Dados - Nome & Notas do Aluno
            Console.WriteLine("Digite os dados do(a) aluno(a): ");
            Console.Write("Nome do(a) aluno(a): ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite as três notas do(a) aluno(a): ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de Dados - Nota Final
            Console.WriteLine("\nNota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            //Condicional - Aprovado ou Reprovado
            if (aluno.Aprovado())
            {
                Console.WriteLine("\nAPROVADO!");
            }
            else
            {
                Console.WriteLine("\nREPROVADO!");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS!");
            }
        }
    }
}
