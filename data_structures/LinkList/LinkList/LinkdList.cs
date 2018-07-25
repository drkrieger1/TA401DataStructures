using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class LinkdList
    {
        //Head of the list
        public Node Head { get; set; }

        //Add From the Head O(1)
        public void AddHead(Node node) 
        {
            //check to make sure List is empty
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        
        //Add From the Tail O(n)



        //Delete Node
    }
}
