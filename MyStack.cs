using System;
namespace GenericÖdev
{

    public class MyStack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public int Count => list.Count;

        public void Push(T item)
        {
            list.AddLast(item);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack boş.");

            T value = list.Last!.Value;
            list.RemoveLast();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack boş.");

            return list.Last!.Value;
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public void Print()
        {
            Console.Write("Stack (Top to Bottom): ");
            var items = list.Reverse();
            foreach (var item in items)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }


}

