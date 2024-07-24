using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modificadores_Acesso;

namespace Modificadores_Acesso
{
    //criacao de uma classe
    public class Pessoa
    {
        //atributos (caracteriscas) publicos 
        public string Nome;
        public int Idade;

        // metodo (acao) da classe ela exige um retorno , nesse caso é nulo
        public void Aprensetar()
        {
            System.Console.WriteLine($"Me chamo {Nome} e tenho {Idade} anos.");
        }
    }


class Program
{
    static void Main()
    {   // instacia da classe Pessoa 
        var p = new Pessoa();
        // atribuicao de dados na estrutura da classe pessoa (como ela é publica) essa atruibuicao é possivel.
        p.Idade = 19;
        p.Nome = "Pedro";
        p.Aprensetar();
    }
}