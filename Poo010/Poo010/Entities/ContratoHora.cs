namespace Poo010.Entities
{
    internal class ContratoHora
    {
        //Atributos da Classe - Dados do Contrato
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }

        //Construtor da Classe - Dados do Contrato
        public ContratoHora(DateTime data, double valorPorHora, int hora)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Hora = hora;
        }

        //Função - Valor Total do Contrato
        public double ValorTotal()
        {
            return Hora * ValorPorHora;
        }
    }
}
