using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a nota");
            var nota = Console.ReadLine();
            
            Console.WriteLine("digite a segunda nota");
            var nota2 = Console.ReadLine();

            double nota01 = Convert.ToDouble(nota);
            double nota02 = Convert.ToDouble(nota2);

            double media = (nota01 + nota02) / 2;

            if(media == 10)
                Console.WriteLine("nota perfeita, aprovado");
            if(media >= 7)
                Console.WriteLine("aprovado");
            if(media < 7 )
                Console.WriteLine("reprovado");  

           Console.WriteLine("resultado " + Math.Round(media, 2));

        }
    }
}
