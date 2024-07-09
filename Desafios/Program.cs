using System;

namespace Desafios
{
    class P1
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
    }

    class P2
    {
        public double X2 { get; set;}
        public double Y2 { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            P1 p1 = new P1();
            p1. X1 = 1.0;
            p1. Y1 = 7.0;

            P2 p2 = new P2();
            p2. X2 = 5.0;
            p2. Y2 = 9.0;

            double diferencax = p2.X2 - p1.X1;
            double diferencay = p2.Y2 - p1.Y1;

            Console.WriteLine(diferencax);
            Console.WriteLine(diferencay);

            double distancia = Math.Sqrt(Math.Pow(diferencax ,2 ) + Math.Pow(diferencay , 2));
            
            Console.WriteLine(distancia.ToString("0.0000"));
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura das coordenadas dos pontos p1 e p2
        string[] linha1 = Console.ReadLine().Split(' ');
        string[] linha2 = Console.ReadLine().Split(' ');

        // Convertendo para double
        double x1 = double.Parse(linha1[0]);
        double y1 = double.Parse(linha1[1]);
        double x2 = double.Parse(linha2[0]);
        double y2 = double.Parse(linha2[1]);

        // Calculando a distância entre os pontos
        double diferencaX = x2 - x1;
        double diferencaY = y2 - y1;
        double distancia = Math.Sqrt(Math.Pow(diferencaX, 2) + Math.Pow(diferencaY, 2));

        // Exibindo a distância com 4 casas decimais
        Console.WriteLine(distancia.ToString("F4"));
    }
}
