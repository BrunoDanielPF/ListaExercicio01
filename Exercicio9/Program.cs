using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que peça uma data no formato 
            dd/mm/aaaa e determine se a mesma é uma data válida. */
           Console.WriteLine("infomr a data no formato dd/mm/aaaa para verificar a validade"); 
           Console.WriteLine("dia ? ");
           int dia = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("mes? ");
           int mes = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("ano? ");
           int ano = Convert.ToInt32(Console.ReadLine());

            Data verificador = new Data();
            verificador.VerificaData(dia,mes,ano);

        }
    }
}
