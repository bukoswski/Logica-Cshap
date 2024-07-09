using System;
namespace soma
{
    class Program
    {
        static void Main(string[]agrs)
        {
            int a = 0;
            int b = 0;
            int sum = 0;
            Console.WriteLine("Qual o primeiro numero? ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("E o segundo numero? ");
            b = int.Parse(Console.ReadLine());
            sum = a + b;    
            Console.WriteLine($"X = {sum}");
        }
    }
}