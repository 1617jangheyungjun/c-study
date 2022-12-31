using System.Collections.Generic;
namespace _Stack;
class Program
{
    static void Main(string[] args)
    {
        // queue
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("one");
        queue.Enqueue("two");
        queue.Enqueue("three");
        queue.Enqueue("four");

        while(queue.Count > 0)
        {
            Console.WriteLine("Dequeue : {0}, Count : {1}", queue.Dequeue(), queue.Count);
        }

        // stack
        Stack<string> Book= new Stack<string>();
        Book.Push("스택을 쌓기1");
        Book.Push("스택을 쌓기2");
        Book.Push("스택을 쌓기3");
        Book.Push("스택을 쌓기4");
        
        while(Book.Count > 0)
        {
            Console.WriteLine(Book.Pop());
        }

    }
}
