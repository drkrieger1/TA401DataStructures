using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class Node
    {
        //Data property
        public int Value { get; set; }
        //Pointer to the next node
        public Node Next { get; set; }

        //Constructor for Node class
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
