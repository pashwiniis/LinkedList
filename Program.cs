using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListclass list1 = new LinkedListclass();
            list1.Add(56);
           // list1.Add(30);
            list1.Add(70);
            list1.InsertAtParticularPosition(2,30);
            list1.Display();
            LinkedListclass list2 = new LinkedListclass();
            //Appends the Nodes
            list2.AddFirst(56);
            list2.AddFirst(30);
            list2.AddFirst(70);
            //Remove first node 50 from the linked list
            list2.RemoveFirstNode();
            list2.Display();
            Console.ReadKey();
        }
    }
}