using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe seu salario por gentileza");
            double salario = Convert.ToDouble(Console.ReadLine());

            Calculo folhaPagamento = new Calculo();
            double resultadoIR, resultadoINSS, resultadoFGTS, resultadoLiquido;

            resultadoIR = folhaPagamento.IR(salario);
            resultadoINSS = folhaPagamento.INSS(salario);
            resultadoFGTS = folhaPagamento.FGTS(salario);
            resultadoLiquido = salario - (resultadoIR + resultadoINSS);

            Console.WriteLine("( - ) IR: " + resultadoIR +
            "\n( - ) INSS (10%): " + resultadoINSS +
            "\nFGTS (11%) : " + resultadoFGTS +
            "\nsalario liquido:" + resultadoLiquido);
        }
    }
}
