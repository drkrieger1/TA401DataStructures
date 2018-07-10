using System;
using Graph.Classes;
using Xunit;

namespace XUnitTestGraphs
{
    public class UnitTest1
    {
        [Fact]
        public void SizeReturnsTheCorrectNumberOfNodes()
        {
            Node node1 = new Node("a");
            Node node2 = new Node("b");
            Node node3 = new Node("c");

            Graphs myGraph = new Graphs(node1);
            myGraph.Root.Children.Add(node2);
            myGraph.Root.Children[0].Children.Add(node2);
            myGraph.Root.Children[0].Children.Add(node3);

            int result = myGraph.Size(myGraph.Root);

            Assert.Equal(3, result);
        }
    }
}
