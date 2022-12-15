using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class LinkedListStack
    {

            private Node top;

            public LinkedListStack()
            {
                this.top = null;
            }

            public void push(int value)
            {
                Node node = new Node(value);
                if (this.top == null)
                {
                    node.next = null;
                }
                else
                {
                    node.next = this.top;
                }
                this.top = node;
            Console.WriteLine(value + "inserted into the stack Successfully");
            }
        public void peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n{0} is top of stack ", this.top.data);
        }


        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty, Deletion is not possible");
            }
            Console.WriteLine("Elememnt Deleted from the Stack is " + this.top.data);
            this.top = this.top.next;
        }
        public void isEmpty()
        {
            while (this.top != null)
            {
                peak();
                pop();
            }
            Console.WriteLine("Stack is empty");
        }
        public void Display()
        {
            Console.WriteLine("Stack");
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
