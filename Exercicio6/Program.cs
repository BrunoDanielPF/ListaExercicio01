using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite");
            Int32 console = Convert.ToInt32(Console.ReadLine());

            Semana resultado = new Semana();

            resultado.dia(console);
        }
    }
}
