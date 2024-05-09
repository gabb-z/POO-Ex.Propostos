using Poo010.Entities.Enums;

namespace Poo010.Entities
{
    internal class Funcionario
    {
        //Atributos da Classe - Dados do Funcionário
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public double SalarioBase { get; set; }

        //Associação de Tipos - Departamento & Contratos
        public Departamento Departamento { get; set; }
        List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();

        //Construtor da Classe - Dados do Funcionário
        public Funcionario(string nome, NivelFuncionario nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }  

        //Função da Classe - Adicionar Contrato
        public void AddContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        //Função da Classe - Ganho Total do Funcionário
        public double GanhoTotal(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
