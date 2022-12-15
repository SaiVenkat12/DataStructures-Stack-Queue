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

            public void Display()
            {
                Node temp = this.top;
                while (temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
            }
    }
}
