namespace Poo012.Entities
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        //Atributo da Classe - Funcionário Terceirizado
        public double DespesaAdicional { get; set; }

        //Construtor da Classe - Funcionário Terceirizado
        public FuncionarioTerceirizado(string nomeFunc, int horas, double valorPorHora, double despesaAdicional) : base (nomeFunc, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        //Função da Classee - Pagamento do Funcionário Terceirizado + 110% Sobre Despesa Adicional
        public override double Pagamento()
        {
            return base.Pagamento() + (110 * DespesaAdicional) / 100.0;
        }
    }
}
