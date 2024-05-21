namespace Poo014.Entities
{
    internal class PessoaFisica : Contribuintes
    {
        //Atributo da Classe - Pessoa Física
        public double GastoSaude { get; set; }

        //Construtor da Classe - Pessoa Física
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        //Função da Classe - Imposto Pessoa Física
        public override double Imposto()
        {
            double soma = 0;

            if (RendaAnual < 20000.00)
            {
                soma += ((RendaAnual * 15) / 100.00) - ((GastoSaude * 50) / 100.0);
            }
            else
            {
                soma += ((RendaAnual * 25) / 100.0) - ((GastoSaude * 50) / 100.0);
            }

            return soma;
        }
    }
}
