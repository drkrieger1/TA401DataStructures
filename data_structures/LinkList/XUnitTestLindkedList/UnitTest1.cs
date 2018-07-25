using LinkList;
using System;
using Xunit;

namespace XUnitTestLindkedList
{
    public class UnitTest1
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

        [Fact]
        public void Test()
        {

        }
    }
}
