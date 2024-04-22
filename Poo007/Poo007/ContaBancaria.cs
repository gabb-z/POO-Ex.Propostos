using System;
using System.Globalization;

namespace Poo007
{
    class ContaBancaria
    {
        //Atributos da Classe
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtores da Classe
        public ContaBancaria()
        {

        }
        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }
        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        //Função da Classe - Depósito
        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        //Função da Classe - Saque / Taxa de 5% Sobre Saque
        public double Saque(double valor)
        {
            return Saldo -= valor + 5.0;
        }

        //Override - Objeto para String
        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
