namespace Exercicio9
{
    public class Data
    {
        public void VerificaData(int dia,int mes,int ano){
            if( ano > 1900 && ano <= 2090){
                if(mes >= 1 && mes <= 12){
                    if(dia >= 1 && dia <= 31){
                        if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                            Console.WriteLine("data válida meu cupixa");
                    }
                    if((dia >= 1 && dia <=30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
                            Console.WriteLine("data valida meu cupixa");
                    if((dia >= 1 && dia <=28) && (mes == 2))
                        Console.WriteLine("dia valido de fevereiro");
                    else 
                        Console.WriteLine("dia invalido né meu amigo");
                }
                else Console.WriteLine("esse mes é invalido né burro");
            }
            else Console.WriteLine("esse ano é invalido tu é defundo por acaso");
        }
    }
}