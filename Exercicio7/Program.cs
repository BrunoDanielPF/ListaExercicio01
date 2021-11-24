using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que lê as duas 
            notas parciais obtidas por um aluno numa disciplina ao
             longo de um semestre, e calcule a sua média*/

            Console.WriteLine("digite a primeira nota");
            double notaConsole1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a segunda nota");
            double notaConsole2 = Convert.ToDouble(Console.ReadLine());

            CalculoNota calculo = new CalculoNota();
            calculo.calculo(notaConsole1, notaConsole2);
        }
    }
}
