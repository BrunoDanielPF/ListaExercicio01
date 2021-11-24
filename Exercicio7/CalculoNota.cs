using System;
namespace Exercicio7
{
    public class CalculoNota
    {
        public void calculo(double nota, double nota2)
        {
            double media = (nota + nota2) / 2;

            if (media >= 9.0 && media <= 10)
                Console.WriteLine("CONCEITO: A");

            if (media >= 7.5 && media <= 9.9)
                Console.WriteLine("CONCEITO: B");

            if (media >= 6.0 && media < 7.5)
                Console.WriteLine("CONCEITO: C");

            if (media >= 4.0 && media < 6.0)
                Console.WriteLine("CONCEITO: D");

            if (media < 4)
                Console.WriteLine("CONCEITO: E");
        }
    }
}