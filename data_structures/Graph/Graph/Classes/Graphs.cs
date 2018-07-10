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
        public List<Node> GetNodes()
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();

            breadth.Enqueue(Root);
            Root.Visited = true;
            while(breadth.TryPeek(out Node result))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach(Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;       
        }

        //GetNeighbors()
        public List<Node> GetNeeighbors(Node root)
        {
            return root.Children;
        }

        //Size()
        public int Size(Node root)
        {
            List<Node> Total = BreadthFirst(root);
            return Total.Count;
        }
        //BreadthFirst()
        public List<Node> BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            List<Node> order = new List<Node>();
            breadth.Enqueue(root);
            root.Visited = true;

            while (breadth.TryPeek(out root))
            {
                Node first = breadth.Dequeue();
                order.Add(first);
                foreach(Node child in first.Children)
                {
                    if (!child.Visited)
                    {
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;
        }
    }
}
