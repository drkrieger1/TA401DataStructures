using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graphs
    {   
        //Not needed -- just keeping a refrance of the first node
        public Node Root { get; set; }

        public Graphs(Node node)
        {
            Root = node;
        }
        //AddEdge()
        //<Summery>
        //
        //</Summery>
        //<input>
        public void AddEdge(Node root, Node node)
        {
            root.Children.Add(node);
        }
        //GetNodes()
        //<Summery>
        //
        //</Summery>
        public List<Node> GetNodes(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();

            breadth.Enqueue(root);
            root.Visited = true;
            while(breadth.TryPeek(out root))
            {

            }
            return order;       
        }

        //GetNeighbors()

        //Size()

        //BreadthFirst()
    }
}
