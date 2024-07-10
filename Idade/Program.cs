using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            //contadores individuais 
            int anos = 0;
            int meses = 0;
            int dias = 0;
            // criacao do input
            Console.WriteLine("Qual a sua idade em dias? ");
            //criacao da variavel junto com a conversao
            int idade = int.Parse(Console.ReadLine());
            //condicoes logicas
            if (idade >= 365)
            {
                anos = idade / 365;
                idade = idade % 365;
            }

            if (idade >= 30)
            {
                meses = idade / 30;
                idade = idade % 30;
            }

            dias = idade;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
