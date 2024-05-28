using Poo015.Entities.Exceptions;
using System.Globalization;
using System.Text;

namespace Poo015.Entities
{
    internal class Conta
    {
        //Atributos da Classe - Dados da Conta
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        //Construtor da Classe - Dados da Conta
        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        //Função da Classe - Depósito
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        //Função da Classe - Saque & Teste de Possível Exceção
        public void Saque(double valor)
        {
            if (Saldo < valor)
            {
                throw new AccException("O valor inserido excede o saldo disponível na conta!");
            }
            else if (valor > LimiteSaque)
            {
                throw new AccException("O valor inserido excede o limite de saque da conta!");
            }
            else
            {
                Saldo -= valor;
            }
        }

        //StringBuilder - Saldo Atualizado
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Saldo atualizado: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();
        }
    }
}
