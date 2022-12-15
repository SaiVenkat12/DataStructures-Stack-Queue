using System;
namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.EnQueue(56);
            queue.EnQueue(30);
            queue.EnQueue(70);
            queue.display();


            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.push(70);
            //linkedListStack.push(30);
            //linkedListStack.push(56);
            //linkedListStack.Display();

            //linkedListStack.peak();

            //linkedListStack.pop();
            //linkedListStack.Display();

            //linkedListStack.isEmpty();
            //linkedListStack.Display();

        }
    }
}

