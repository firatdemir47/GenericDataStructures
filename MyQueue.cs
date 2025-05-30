using System;
namespace GenericÖdev
{
    public class MyQueue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public int Count => list.Count;

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kuyruk boş.");

            T value = list.First!.Value;
            list.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Kuyruk boş.");

            return list.First!.Value;
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
            Console.Write("Queue: ");
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }


}

