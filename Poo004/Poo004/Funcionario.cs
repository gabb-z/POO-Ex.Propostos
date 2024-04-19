using System;
using System.Globalization;

namespace Poo004
{
    class Funcionario
    {
        //Atributos da Classe
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Função da Classe - Salário Líquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        //Função da Classe - Aumentar Salário
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100.0;
        }

        //Override - ToString
        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
