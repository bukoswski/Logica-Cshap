using System;
namespace Operaçoes_matetematica
{
    class Program
    {
        static void Main(string[]agrs)
        {
            double conta = (20-15);
            double divi = conta /2;
            double result = divi;

            // metodo 1 tipo e resultado 

            Console.WriteLine($"{result}");
            Console.WriteLine($"{result.GetType()}");

        // metodo 2 com o valor e o tipo

        if (result is int)
        {
            Console.WriteLine($"O valor é {result} e é do tipo int");
        }

        if (result is double)
        {
            Console.WriteLine($"O valor é {result} e é do tipo double");
        }

        }

    }
}