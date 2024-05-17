namespace Poo012.Entities
{
    internal class Funcionario
    {
        //Atributos da Class - Dados do Funcionário
        public string NomeFunc { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        //Construtor da Classe - Dados do Funcionário
        public Funcionario(string nomeFunc, int horas, double valorPorHora)
        {
            NomeFunc = nomeFunc;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        //Função da Classe - Pagamento do Funcionário
        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
