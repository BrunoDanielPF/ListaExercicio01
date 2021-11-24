using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Faça um Programa que peça os 3 lados de um triângulo.
            O programa deverá informar se os valores podem ser um triângulo
            . Indique, caso os lados formem um triângulo, se o mesmo é: equilátero,
             isósceles ou escaleno.*/

            Console.WriteLine("declare 3 lados de um triangulo para saber qual tipode triagulo ele é\n digite o primeiro lado");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo lado do triagulo");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o terceiro lado do triangulo");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            CalculoTriangulo calculo = new CalculoTriangulo();
            calculo.tipoTriangulo(lado1, lado2, lado3);

        }
    }
}
