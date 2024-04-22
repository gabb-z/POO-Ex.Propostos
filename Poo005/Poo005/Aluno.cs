using System;
using System.Globalization;

namespace Poo005
{
    class Aluno
    {
        //Atributos da Classe
        public string Nome;
        public double Nota1, Nota2, Nota3;

        //Função da Classe - Nota Final
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        //Condicional - Aprovado ou Reprovado
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Condicional - Nota Restante se Reprovado
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
