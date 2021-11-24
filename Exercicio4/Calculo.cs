using System;

namespace Exercicio4
{
    public class Calculo
    {
        public void CalculoSalario(double salario)
        {
            double valorFinal;
            if (salario <= 2800)
            {    // VINTE PORCENTO DE AUMENTO
                // valor do aumento com porcentagem
                double percentual20 = 20.0 / 100.0;
                valorFinal = salario + (percentual20 * salario);
                double aumento = valorFinal - salario;
                Console.WriteLine("você ganhou aumento de 20% no total de: " + valorFinal
                + "\nseu salario era: " + salario + "\nteve aumento de: " + aumento);
            }
            if (salario >= 2800 && salario <= 7000)
            { // QUINZE PORCENTO DE AUMENTO
                double percentual15 = 15.0 / 100.0;
                valorFinal = salario + (percentual15 * salario);
                double aumento = valorFinal - salario;
                Console.WriteLine("você ganhou aumento de 15% no total de: " + valorFinal
                + "\nseu salario era: " + salario + "\nteve aumento de: " + aumento);
            }
            if (salario > 15000)
            {    // CINCO PORCENTO DE AUMENTO
                double percentual5 = 05.0 / 100.0;
                valorFinal = salario + (percentual5 * salario);
                double aumento = valorFinal - salario;
                Console.WriteLine("você ganhou aumento de 5% no total de: " + valorFinal
                + "\nseu salario era: " + salario + "\nteve aumento de: " + aumento);
            }
        }
    }
}