using LinkList;
using System;
using Xunit;

namespace XUnitTestLindkedList
{
    public class LinkdListUnitTest
    {
        [Fact]
        public void LinkedListHeadPointerIsNull()
        {
            //Arange

            //Act 
            LinkdList testList = new LinkdList();

            //Assert
            Assert.Null(testList.Head);
        }

    }
    public class NodeUnitTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(200)]
        [InlineData(3000)]
        public void CanCreateNode(int input)
        {
            //Arange
            Node testNode = new Node(input);

            //Act 
            int result = testNode.Value;

            //Assert
            Assert.Equal(input, result);
            Assert.IsType<Node>(testNode);
            Assert.Null(testNode.Next);
        }
    }
}
