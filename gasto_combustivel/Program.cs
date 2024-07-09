using System;
namespace gasto_combustivel
{
    class Program
    {
        static void Main(string[]agrs)
        {
            int tempo = 0;
            int velocidade = 0;
            double consumo =0;
            double distancia =0;
            Console.WriteLine("Qual o tempo gasto? ");
            tempo = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Qual a velocidade media? ");
            velocidade= int.Parse(Console.ReadLine());
            distancia = tempo * velocidade;
            consumo = distancia / 12;
            Console.WriteLine($"O consumo é {consumo:F3}");
        }
    }
}