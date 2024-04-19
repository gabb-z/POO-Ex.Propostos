using System;

namespace Poo001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Pessoa
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            //Entrada de Dados - 1ª Pessoa
            Console.WriteLine("Dados da 1ª pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            //Entrada de Dados - 2ª Pessoa
            Console.WriteLine("\nDados da 2ª pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            //Condicional - Pessoa Mais Velha
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
            }

            else
            {
                Console.WriteLine("\nPessoa mais velha: " + p2.Nome);
            }
        }
    }
}
