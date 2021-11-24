using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero");
            var numero1 = Console.ReadLine();

            Console.WriteLine("digite o segundo numero");
            var numero2 = Console.ReadLine();

            Console.WriteLine("digite o terceiro numero");
            var numero3 = Console.ReadLine();

            int numeroc1 = Convert.ToInt32(numero1);
            int numeroc2 = Convert.ToInt32(numero2);
            int numeroc3 = Convert.ToInt32(numero3);


            int maior = 0;
            int menor = 0;

            // MAIOR // // // // 
            if (numeroc1 > numeroc2)
                if (numeroc1 > numeroc3) maior = numeroc1;
                    else maior = numeroc3;
            if (numeroc2 > numeroc3)
                if (numeroc2 > numeroc1) maior = numeroc2;
                    else maior = numeroc3;
            // MENOR // // // // 
            if(numeroc1 < numeroc3)
                if(numeroc1 < numeroc2) menor = numeroc1;
                    else menor = numeroc3;
            if(numeroc2 < numeroc3)
                if(numeroc2 < numeroc1) menor = numeroc2;
                    else menor = numeroc3;
            
            Console.WriteLine("o maior resultado é : " + maior);
            Console.WriteLine("o menor resultado é : " + menor);
        }
    }
}
