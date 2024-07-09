using System;

namespace contagem_cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int valor;

            Console.WriteLine("Quanto você tem? ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 100)
            {
                cont = valor / 100;
                valor = valor % 100;
                Console.WriteLine($"{cont} nota(s) de R$ 100,00");
            }

            if (valor >= 50)
            {
                cont = valor / 50;
                valor = valor % 50;
                Console.WriteLine($"{cont} nota(s) de R$ 50,00");
            }
            if (valor >= 20)
            {
                cont = valor / 20;
                valor = valor % 20;
                Console.WriteLine($"{cont} nota(s) nota(s) de R$ 20,00");
            }
            if (valor >= 10)
            {
                cont = valor / 10;
                valor = valor % 10;
                Console.WriteLine($"{cont} nota(s) nota(s) de R$ 10,00");
            }
            if (valor >= 5)
            {
                cont = valor / 5;
                valor = valor % 5;
                Console.WriteLine($"{cont} nota(s) nota(s) de R$ 5,00");
            }
            if (valor >= 2)
            {
                cont = valor / 2;
                valor = valor % 2;
                Console.WriteLine($"{cont} nota(s) de R$ 2,00");
            }
            if (valor >= 1)
            {
                cont = valor;
                valor = 0;
                Console.WriteLine($"{cont} nota(s) de R$ 1,00");
            }
        }
    }
}


