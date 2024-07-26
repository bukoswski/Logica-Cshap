using System;

//classe Da arvore, criando o Nó
class Node
{
    // Nó esquerdo
    public Node? Left { get; set; }
    //Nó direito
    public Node? Right { get; set; }
    //Valor dos nós
    public string Value { get; set; }
//construtor da classe node
    public Node(string value, Node? left = null, Node? right = null)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
}

//class pra leitura dos valores 
static class ReadTree
{
    public static void Preorder(Node? node, Action<string> action)
    {
        if (node is null) return;

        action(node.Value);
        Preorder(node.Left, action);
        Preorder(node.Right, action);
    }
}

class Program
{
    static void Main()
    {//Valores dentro da arvore
        Node tree = new Node("A",
            new Node("B",
                new Node("D", new Node("H")),
                new Node("E")),
            new Node("C",
                new Node("F", new Node("I")),
                new Node("G", new Node("J"), new Node("K"))));
//mostre os valores na tela.
        ReadTree.Preorder(tree, letter => Console.Write($"{letter}"));
    }
}
