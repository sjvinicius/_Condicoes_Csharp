using System;

namespace _Condicionais_C_
{
    class Program
    {
        static void Main(string[] args)
        {

                // EXERCICIO MEDIA

            // Console.WriteLine("BEM VINDO");
            // Console.Write("Por favor, insira sua 1o Nota: ");
            // double not1 = double.Parse( Console.ReadLine() );
            // Console.Write("Por favor, insira sua 2o Nota: ");
            // double not2 = double.Parse( Console.ReadLine() );

            // double media = (not1 + not2) / 2; 

            // if (media < 7 ) {
            //     Console.WriteLine(" Infelizmente sua situação é REPROVADO");
            //     Console.WriteLine(" Média: " + media);
            // } else {
            //     Console.WriteLine(" PARABENS SUA SITUAÇÃO É APROVADOO !!! ");
            //     Console.WriteLine("MÉDIA: " + media);
            // }

                // Exercicio FAROL


            Console.WriteLine("Olá Motorista !! Qual a cor do semáforo ?");
            Console.WriteLine("Digite :");
            Console.WriteLine("0. Vermelho");
            Console.WriteLine("1. Amarelo");
            Console.WriteLine("2. Verde");
            int farol = int.Parse(Console.ReadLine());

            if ( farol >=0 && farol < 2 ) {
                Console.WriteLine("Não prossiga, aguarde o sinal verde ! ");

            }
            else if ( farol >=2 && farol < 3 ) {
                Console.WriteLine("Prossiga, boa viagem !!! ");

            }
            else {
                Console.WriteLine(" ALERTA !!! " + farol +  " Não é um valor válido !!! ");

            }
        }
    }
}
