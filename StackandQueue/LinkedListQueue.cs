using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class LinkedListQueue
    {
        Node head = null;
        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {

                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " is inserted into the Queue");
        }
        public void DeQueue()
        {

            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("{0} is removed from the Queue", this.head.data);
                this.head = this.head.next;
            }
        }
            public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue ");
                Node temp = head;
                while (temp != null && temp.data != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp = temp.next;
                }
            }
        }
    }
}
