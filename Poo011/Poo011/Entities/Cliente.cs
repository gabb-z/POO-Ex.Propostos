namespace Poo011.Entities
{
    internal class Cliente
    {
        //Atributos da Classe - Dados do Cliente 
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataNascimento { get; set; }

        //Construtor da Classe - Dados do Cliente
        public Cliente(string nomeCliente, string emailCliente, DateTime dataNascimento)
        {
            NomeCliente = nomeCliente;
            EmailCliente = emailCliente;
            DataNascimento = dataNascimento;
        }

        //Override ToString - Dados do Cliente
        public override string ToString()
        {
            return NomeCliente + " (" + DataNascimento.ToString("dd/MM/yyyy") + ") - " + EmailCliente;  
        }
    }
}
