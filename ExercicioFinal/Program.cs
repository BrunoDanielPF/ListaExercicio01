using System;

namespace ExercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero para saber se é par ou impar");
            double numero = Convert.ToDouble(Console.ReadLine());

            Verificador verifica = new Verificador();
            verifica.ParouImpar(numero);
        }
    }
}
