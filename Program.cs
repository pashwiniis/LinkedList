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
            Console.WriteLine("Welcome to Linked List program");
            Console.WriteLine("Adding the elements in the linked list");
            LinkedListclass list1 = new LinkedListclass();
            list1.Add(56);
            list1.Add(30);
            list1.Add(70);
           list1.Display();

            //INsert at particular position
            Console.WriteLine("Insert the node at partucular Positon");
            LinkedListclass list2 = new LinkedListclass();
            list2.Add(56);
            list2.Add(70);
            //insert the 40 new node to the given linked list
            list2.InsertAtParticularPosition(2, 40);
            list2.InsertAtParticularPosition(3, 30);
          
            list2.Display();
            Console.WriteLine("Successfully inserted the new node ");
            list2.RemoveNodeAtParticularPosition(2);
            list2.Display();
            Console.WriteLine("After deleting the Node Linked List size is  "+ list2.LinkedListSize());
            //Appends the Nodes
            Console.WriteLine("The node 50 is first cretated then appends 30 and 70");
            LinkedListclass list3 = new LinkedListclass();
            list3.AddFirst(56);
            list3.AddFirst(30);
            list3.AddFirst(70);
            list3.Display();

            //Remove first node 50 from the linked list
            Console.WriteLine("Removed the first node from the linked list");
            LinkedListclass list4 = new LinkedListclass();
            list4.Add(56);
            list4.Add(30);
            list4.Add(70);
            list4.RemoveFirstNode();
            list4.Display();

            //Removed Last Node 70 from the linked list
            Console.WriteLine("Removed the last node from the linked list");
            LinkedListclass list5 = new LinkedListclass();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.RemovaLastNode();
            list5.Display();

            //Search Node 30 from the given liked list
            Console.WriteLine("Searching the Nodes");
            LinkedListclass list6 = new LinkedListclass();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            list6.Search(30);
            list6.Display();

            Console.ReadKey();
        }
    }
}