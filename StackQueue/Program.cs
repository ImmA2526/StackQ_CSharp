using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome To Stack Program********");
        	Console.WriteLine("********Welcome To Stack Program********");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            Console.WriteLine("Inserted Elements Are ");
            stack.Display();
            stack.Pop();
            Console.WriteLine("After Pop.. ");
            stack.Display();
            stack.Peek();
            
        }
    }
}
