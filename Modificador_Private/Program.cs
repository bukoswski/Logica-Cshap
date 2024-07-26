using System;

namespace Modificador_Private
{   //coriacao da classe Pessoa
    public class Pessoa
    {   //Construtor da classe Pessoa
        public Pessoa(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        //enacapsulamento de dados com possivel alteração atraves do public Name.
        private string _name;
        public string Name
        { //public Name tem perssao para ver o valor de _name (que esta encapsulado)
            get {return _name;}
        // public Name tem permissao para alterar o valorn de _name (que esta encapsulado)
            set {_name = value;}
        }// Age é public
        public int Age { get; set; }
        //mesma coisa do Name
        private string _email;
        public string Email
        
        { 
            get{return _email;} 
            
            set{_email = value;} 
        
        }

        // metodo apresentar, mostro os dados que estao nas minha variaveis
        public void Apresenta()
        {
            System.Console.WriteLine($"Me Chamo {Name} Tenho {Age} anos e meu email é {Email}");
        }
    }

    class Program
    {
        static void Main()
        {//instancia da classe Pessoa com o construtor
            var pessoa = new Pessoa("Pedro", 19, "Pedro@gmail.com");
            pessoa.Apresenta();// instancia do metodo apresentar
            System.Console.WriteLine(pessoa.Email);//instancia do _email que esta private 
            System.Console.WriteLine(pessoa.Name);//instancai do _name que esta private 
        }
    }
}