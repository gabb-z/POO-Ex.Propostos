namespace Poo010.Entities
{
    internal class Departamento
    {
        //Atributo da Classe - Nome do Departamento
        public string NomeDepto { get; set; }

        //Construtor da Classe - Departamento
        public Departamento(string nomeDepto)
        {
            NomeDepto = nomeDepto;
        }
    }
}
