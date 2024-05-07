using System;
using System.Globalization;

namespace Poo009
{
    internal class Funcionario
    {
        //Atributos da Classe
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; private set; }

        //Construtor da Classe
        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        //Função da Classe - Aumentar "%" do Salário
        public void AumentarSalario(double valor)
        {
            Salario += valor * Salario / 100.0;
        }

        //Override - ToString
        public override string ToString()
        {
            return "Nome: " + Nome + ", ID: " + Id + ", Salário: R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
