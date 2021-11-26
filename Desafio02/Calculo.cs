using System;
namespace Exercicio5
{
    public class Calculo
    {
        public double IR(double salario)
        {
            double total = 0;
            double descIR = 0;
            if (salario <= 2000)
            {
                total = 0;
            }
            if (salario >= 2000 && salario <= 5000)
            {
                descIR = 5.0 / 100.0;
                total = salario - (descIR * salario);
                total = salario - total;
            }
            if (salario >= 5000 && salario <= 7000)
            {
                descIR = 10.0 / 100.0;
                total = salario - (descIR * salario);
                total = salario - total;
            }
            if (salario >= 7000 && salario > 15000)
            {
                descIR = 20.0 / 100.0;
                total = salario - (descIR * salario);
                total = salario - total;

            }
            return total;
        }
    }
    public double INSS(double salario)
    {
        double total;
        double descINSS = 10.0 / 100.0;

        total = salario - (descINSS * salario);
        total = salario - total;
        return total;
    }
    public double FGTS(double salario)
    {
        double total;
        double descFGTS = 11.0 / 100.0;
        total = salario - (descFGTS * salario);
        total = salario - total;
        return total;
    }
}