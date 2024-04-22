using System;
using System.Globalization;

namespace Poo006
{
    class ConversorDeMoeda
    {
        //Atributo Estático - Iof 6%
        public static double Iof = 6.0;

        //Função Estática de Conversão - Dólar para Real
        public static double DolarParaReal(double cotacao, double qtde)
        {
            double total = cotacao * qtde;
            return total + total * Iof / 100.0;
        }
    }
}
