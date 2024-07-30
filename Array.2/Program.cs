using System;

//estrutura do array
class Estrutura
{
    //metodo do que ira criar o array
    public static void dados (int [] array, out int primeiro, out int segundo, out int terceiro)
    {
        // igualando todos com 0
        primeiro = segundo = terceiro = 0;
        //iteração com os elementos
        foreach (int numero in array)
        {
            //logica aplicada na solucao
            if(numero > primeiro)
            {
                terceiro = segundo;
                segundo = primeiro;
                primeiro = numero;
            }
            else if (numero > segundo)
            {
                terceiro = segundo; 
                segundo = numero;
            }
            else if (numero > terceiro)
            {
                terceiro = numero;
            }
        }
    }


    // metodo main para rodar o codigo
    public static void Main()
    {   // insercao dos numeros no array
        int [] array = { 6, 8, 1, 9, 2, 1, 10, 10};
        //chamando o metodo estatico
        Estrutura.dados (array, out int primeiro, out int segundo, out int terceiro);
        // monstrando no terminal quais sao os maiores elementos do array
        Console.WriteLine("Os três maiores números no array são: " + primeiro + ", " + segundo + ", " + terceiro);
    }

}

