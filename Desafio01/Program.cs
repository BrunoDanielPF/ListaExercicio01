using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // debugar formato de texto com try catch 
            try
            {
                Console.WriteLine("Digite o salário que será reajustado");
                double salario = Convert.ToDouble(Console.ReadLine());

                double percentualReajuste = 0;
                double valorAumento = 0;
                double novoSalario = 0;

                while (salario > 0)
                {
                    if (salario < 2800)
                        percentualReajuste = 0.2;
                    else if (salario >= 2800 && salario < 7000)
                        percentualReajuste = 0.15;
                    else if (salario >= 7000 && salario < 15000)
                        percentualReajuste = 0.1;
                    else
                        percentualReajuste = 0.05;

                    valorAumento = percentualReajuste * salario;
                    novoSalario = valorAumento + salario;

                    Console.WriteLine($"O salário original é {salario}.\nO percentual de reajuste foi de {percentualReajuste * 100}.\nO valor real do aumento foi de {valorAumento}.\nO novo salário é {novoSalario}");
                    break;
                }
                if (salario < 0)
                    Console.WriteLine("salario invalido");
            }
            catch (Exception err)
            {
                Console.WriteLine($"error : " + err.Message);
            }
        }
    }
}