namespace Poo014.Entities
{
    internal class PessoaJuridica : Contribuintes
    {
        //Atributo da Classe - Pessoa Jurídica
        public int QtdFuncionarios { get; set; }

        //Construtor da Classe - Pessoa Jurídica
        public PessoaJuridica(string nome, double rendaAnual, int qtdFuncionarios) : base(nome, rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        //Função da Classe - Imposto Pessoa Jurídica
        public override double Imposto()
        {
            if (QtdFuncionarios > 10)
            {
                return (RendaAnual * 14) / 100.0;
            }
            else
            {
                return (RendaAnual * 16) / 100.0;
            }
        }
    }
}
