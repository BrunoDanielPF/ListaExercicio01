using System;
namespace ExercicioFinal
{
    public class Verificador
    {
        public void ParouImpar(double numero){
            if(numero % 2 == 0)
                Console.WriteLine(" é par meu amigo");
            else Console.WriteLine( "é impar mesmo");
        }
    }
}