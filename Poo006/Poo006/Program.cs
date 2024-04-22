using System;
using System.Globalization;

namespace Poo006
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados - Cotação & Compra de Dólar
            Console.Write("Digite a cotação atual do dólar: R$ ");
            double cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade que deseja comprar em dólar: $ ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de Dados - Valor à pagar em R$
            Console.WriteLine("\nValor à ser pago em reais: R$ " + ConversorDeMoeda.DolarParaReal(cotação, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
