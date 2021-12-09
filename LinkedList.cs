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
        internal void AddFirst(int data)
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
            Console.WriteLine("{0} inserted into the Append linked list", node.data);
        }

        internal Nodes InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Nodes(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Nodes temp = this.head;
                while (position-- != 0) //
                {

                    if (position == 1)
                    {
                        Nodes node = new Nodes(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        internal Nodes RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal Nodes RemovaLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Nodes newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        internal Nodes Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        internal void Display()
        {
            Nodes temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
            Console.WriteLine("\n");
        }

       

    }
}
