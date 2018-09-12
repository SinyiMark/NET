using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue();
            Stack();
        }
        private static void Queue()
        {
            var myQueue = new Queue();
            myQueue.Enqueue("first");
            myQueue.Enqueue("second");
            myQueue.Enqueue("third");
            myQueue.Enqueue("fourth");
            Console.WriteLine("Queue");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myQueue.Peek());
                myQueue.Dequeue();
                Console.WriteLine(myQueue.Count);
            }
        }
        private static void Stack()
        {
            var myStack = new Stack();
            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("third");
            myStack.Push("fourth");
            Console.WriteLine("\nStack");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myStack.Peek());
                myStack.Pop();
                Console.WriteLine(myStack.Count);
            }
        }
    }
}
