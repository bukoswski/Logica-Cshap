using System;
namespace Distancia
{
    class Program

    {
        static void Main(string[] args)
        {
            int Distancia = 0;
            Console.WriteLine("Qual a Distancia em Km? ");
            Distancia = int.Parse(Console.ReadLine());

            int Calculo = Distancia * 2;

            Console.WriteLine($"{Calculo} Minutos");
        }
    }
}

