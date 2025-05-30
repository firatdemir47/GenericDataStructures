using System;
namespace GenericÖdev
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class MyLinkedList<T>
    {
        private Node<T>? head;
        private int count = 0;

        public int Count => count;

        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data)
            {
                Next = head
            };
            head = newNode;
            count++;
        }

        public void AddLast(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }
            count++;
        }

        public void Remove(T data)
        {
            if (head == null) return;

            if (EqualityComparer<T>.Default.Equals(head.Data, data))
            {
                head = head.Next;
                count--;
                return;
            }

            Node<T> current = head;
            while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Data, data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                count--;
            }
        }

        public bool Contains(T data)
        {
            Node<T>? current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    return true;

                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Print()
        {
            Node<T>? current = head;
            Console.Write("LinkedList: ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

}

