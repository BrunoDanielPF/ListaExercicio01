using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = 0;
            bool digitacaoInvalida = true;
            while (digitacaoInvalida)
            {
                try
                {
                    Console.WriteLine("Digite o salário que será reajustado");
                    salario = Convert.ToDouble(Console.ReadLine());

                    if (salario > 0)
                        digitacaoInvalida = false;
                    else
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Salário inválido...");
                }
            }

            double percentualReajuste = 0;
            double valorAumento = 0;
            double novoSalario = 0;

            if (salario < 2800)
            {
                percentualReajuste = 0.2;
            }
            else if (salario >= 2800 && salario < 7000)
            {
                percentualReajuste = 0.15;
            }
            else if (salario >= 7000 && salario < 15000)
            {
                percentualReajuste = 0.1;
            }
            else
            {
                percentualReajuste = 0.05;
            }

            valorAumento = percentualReajuste * salario;
            novoSalario = valorAumento + salario;

            Console.WriteLine($"O salário original é {salario}.\nO percentual de reajuste foi de {percentualReajuste * 100}.\nO valor real do aumento foi de {valorAumento}.\nO novo salário é {novoSalario}");
        }
    }
}