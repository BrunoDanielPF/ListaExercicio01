using System;
namespace Exercicio8
{
    public class CalculoTriangulo
    {
        public void tipoTriangulo(double n1, double n2, double n3){
            if(n1 == n2 || n2 == n1 || n3 == n1 || n3 == n2 ){
               if(n1 == n2 && n1 == n3 )
                Console.WriteLine("triangulo equilatero de três lado iguais"); 
                    else Console.WriteLine("triangulo isosceles de dois lados iguais");
            }else Console.WriteLine("triangulo escaleno de três lado diferentes");
        }
    }
}