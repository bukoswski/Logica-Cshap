using System;
//structure of tree ( nodes)
class Node
{
    //node of left
    public Node? Left { get; set; }
    //node of right
    public Node? Right { get; set; }
    //value of the nodes
    public int Value { get; set; }

    //contructor of tree (nodes)
    public Node(int value, Node? left = null, Node? right = null)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
    //construtor de delecação onde ele vai receber os valores
    public Node(int value) : this(value, null, null) { }
}

//ler os nos 
static class Read_Tree
{
    //loop de iteração de estruturas nao lineares
    public static void Datas(Node? node, Action<int> action)
    {
        //se o valor for zero retorne
        if (node == null) return;
        //se nao for 0 pegue e guarde o valor do filho
        action(node.Value);
        Datas(node.Left, action);
        Datas(node.Right, action);
    }

    //estrutura para somar os elementos 
    public static int Sum(Node? node)
    {
        //se for 0 some 0
        if (node == null)return 0;
        // se noa for 0 some o elemento de acordo com seu filho
        int sum = node.Value;
        sum += Sum(node.Left);
        sum += Sum(node.Right);
        return sum;
    } 
}

//class de esxecução
class Program
{
    static void Main()
    {
        //valores dos nos
        Node tree = new Node(4,
            new Node(2, new Node(1), new Node(3)),
            new Node(7, new Node(6), new Node(9))
        );

        //leitura dos elementos 
        Read_Tree.Datas(tree, value => Console.Write($"{value} "));
        //leitura da soma dos  elemnteos.
        int sum = Read_Tree.Sum(tree);

        Console.WriteLine(" ");
        Console.WriteLine($"A soma dos nós: {sum}");
    }
}
