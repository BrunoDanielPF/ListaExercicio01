using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // informar salario para calculo de aumento
            Console.WriteLine("informe seu salário : ");
            var salarioConsole = Console.ReadLine();
            double salario = Convert.ToDouble(salarioConsole);

            Calculo calculoSalario = new Calculo();
            calculoSalario.CalculoSalario(salario);           
        }
    }
}
