using System;

namespace CelularPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando os atritudos 
            Celular iphone = new Celular();
            iphone.cor = "preto";
            iphone.modelo = "iphone x";
            iphone.tamanho = "medio";
            

             Console.WriteLine("Deseja ligar o celular?");
             iphone.ligado   = Boolean.Parse(Console.ReadLine());
        

            if(iphone.ligado){
                Console.WriteLine("Deseja fazer? / 1-ligação / 2-enviar mensagem");
                int resposta = Int32.Parse( Console.ReadLine() );
                    //switch e usado quando a mais de 3 opções de escolha
                    switch (resposta)
                    {                    
                        case 1:
                        Console.WriteLine( iphone.FazerLigacao() );
                        break;

                        case 2:
                        Console.WriteLine( iphone.EnviarMensagem() );
                        break;

                        default:
                        Console.WriteLine(iphone.Ligar());
                        break;
                    }
                

            }else{
                Console.WriteLine( "o celular esta desligado");
            }
        }
    }
}
