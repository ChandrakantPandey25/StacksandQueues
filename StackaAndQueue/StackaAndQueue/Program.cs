using System;

namespace StackaAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues program");
            Console.WriteLine("Enter 1 to create stack");
            Console.WriteLine("Enter 2 for Pick and Pop from stack");
            Console.WriteLine("Enter 3 to create a queue");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    LinkedList list = new LinkedList();
                    list.Push(70);
                    list.Push(30);
                    list.Push(56);
                    list.Display();
                    break;
                case 2:
                    PickAndPop peak = new PickAndPop();
                    peak.Push(70);
                    peak.Push(30);
                    peak.Push(56);
                    peak.IsEmpty();
                    peak.Display();
                    break;
                case 3:
                    CreatingQueue queue = new CreatingQueue();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Enter Valid number");
                    break;

            }

        }
    }
}
