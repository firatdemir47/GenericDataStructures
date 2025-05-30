using GenericÖdev;

class Program
{
    static void Main()
    {
        var queue = new MyQueue<string>();
        queue.Enqueue("Elma");
        queue.Enqueue("Armut");
        queue.Print();
        Console.WriteLine("Peek: " + queue.Peek());
        queue.Dequeue();
        queue.Print();

        var stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Print();
        Console.WriteLine("Peek: " + stack.Peek());
        stack.Pop();
        stack.Print();

        var list = new MyLinkedList<double>();
        list.AddLast(1.1);
        list.AddFirst(0.5);
        list.AddLast(2.2);
        list.Print();
        Console.WriteLine("Contains 2.2? " + list.Contains(2.2));
        list.Remove(1.1);
        list.Print();
        Console.ReadKey();
    }
}

