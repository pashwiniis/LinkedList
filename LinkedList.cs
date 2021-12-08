using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListclass
    {
        internal Nodes head; //new


        internal void Add(int data)
        {
            Nodes node = new Nodes(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Nodes temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
    }
}
