using System;

namespace StackaAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues program");
            LinkedList list = new LinkedList();            
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
        }
    }
}
