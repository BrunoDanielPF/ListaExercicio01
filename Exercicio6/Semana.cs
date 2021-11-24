using System;
namespace Exercicio6
{
    public class Semana
    {
        public void dia(int data){
            switch (data)
            {
            case 1:
                 Console.WriteLine("Segunda-Feira");
              break;
            case 2:
                Console.WriteLine("terça-feira");
                break;
            case 3:
                Console.WriteLine("quarta-feira");
                break;
            case 4:
                Console.WriteLine("quinta-feira");
                break;
            case 5:
                Console.WriteLine("sexta-feira");
                break;
            case 6:
                Console.WriteLine("sabado-feira");
                break;
            case 7:
                Console.WriteLine("domingo");
                break;
            default: 
                Console.WriteLine("numero invalido");
                break;
            }
        }
    }
}