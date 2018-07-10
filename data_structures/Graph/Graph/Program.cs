using Graph.Classes;
using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node("a");
            Node node2 = new Node("b");
            Node node3 = new Node("c");

            Graphs myGraph = new Graphs(node1);
            myGraph.Root.Children.Add(node2);
            myGraph.Root.Children[0].Children.Add(node2);
            myGraph.Root.Children[0].Children.Add(node3);

            int result = myGraph.Size(myGraph.Root);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
