using System.Text;
using System.Globalization;

namespace Poo014.Entities
{
    internal abstract class Contribuintes
    {
        //Atributos da Classe - Dados do Contribuinte
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        //Construtor da Classe - Dados do Contribuinte
        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        //Função da Classe - Imposto do Contribuinte
        public abstract double Imposto();

        //StringBuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome + " - R$ " + Imposto().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
