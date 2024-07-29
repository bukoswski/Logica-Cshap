using System;
namespace Area_Circulo
{
    class Program
    {
        static void Main(string[]args)
        {
            double pi = 3.14159;
            double raio = 0;
            double area = 0;

            Console.WriteLine("Qual o raio? ");
            raio = double.Parse(Console.ReadLine());
            area = pi* Math.Pow(raio,2);
            Console.WriteLine($"A={area:F4}");
        }
    }    
}
