using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- informe o nome do produto");
            var nomeProd1 = Console.ReadLine().ToUpper();
            Console.WriteLine("1- informe o valor do produto");
            var valorProd1 = Console.ReadLine();
            double valor1 = Convert.ToDouble(valorProd1);

            Console.WriteLine("2- informe o nome do produto");
            var nomeProd2 = Console.ReadLine().ToUpper();
            Console.WriteLine("2- informe o valor do produto");
            var valorProd2 = Console.ReadLine();
            double valor2 = Convert.ToDouble(valorProd2);

            Console.WriteLine("3- informe o nome do produto");
            var nomeProd3 = Console.ReadLine().ToUpper();
            Console.WriteLine("3- informe o valor do produto");
            var valorProd3 = Console.ReadLine();
            double valor3 = Convert.ToDouble(valorProd3);




            if (valor1 < valor2 && valor1 < valor3)
                Console.WriteLine("voce deveria compra: " + nomeProd1 + " no valor de: " + valor1);

            if (valor2 < valor1 && valor2 < valor3)
                Console.WriteLine("voce deveria comprar: " + nomeProd2 + " no valor de: " + valor2);

            if (valor3 < valor2 && valor3 < valor1)
                Console.WriteLine("você deveria comprar: " + nomeProd3 + " no valor de: " + valor3);
                
            //else Console.WriteLine("erro generico, tente novamente");

        }
    }
}
