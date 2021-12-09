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
        internal void  RemoveNodeAtParticularPosition(int position)
        {

            // If linked list is empty
            if (head == null)
                return;

            // Store head node
            Nodes temp = head;

            // If head needs to be removed
            if (position == 0)
            {

                // Change head
                head = temp.next;
                return;
            }

            // Find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.next;

            // If position is more than number of nodes
            if (temp == null || temp.next == null)
                return;

            // Node temp->next is the node to be deleted
            // Store pointer to the next of node to be deleted
            Nodes next = temp.next.next;

            // Unlink the deleted node from list
            temp.next = next;
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
        internal void sortList()
        {
            //Node current will point to head  
            Nodes current = head, index = null;
            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.data > index.data)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }

        internal int LinkedListSize()
        {
            Nodes temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

    }
}
