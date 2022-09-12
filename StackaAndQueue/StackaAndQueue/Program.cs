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
                    PeekAndPop stack = new PeekAndPop();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);                
                    
                    stack.Display();
                    stack.Peek();
                    stack.Pop();
                    stack.Display();
                    stack.IsEmpty();
                    break;
                default:
                    Console.WriteLine("Enter Valid number");
                    break;

            }

        }
    }
}
