using System;
using System.Globalization;

namespace Poo003
{
    class Produto
    {
        //Atributos da Classe
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Função da Classe - Calculo do Valor Total do Estoque
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        //Função da Classe - Add. Produtos
        public void AddProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Função da Classe - Remov. Produtos
        public void RemovProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //Override - ToString
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade(s), " + "Total em estoque: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
