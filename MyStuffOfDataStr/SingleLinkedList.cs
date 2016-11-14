using System;

namespace MyStuffOfDataStr
{
    public class SingleLinkedList
    {
        private Node head;
        private int count;

        public SingleLinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public void DisplayList()
        {
            Node current;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("List is: ");
            current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data + "");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void CountNode()
        {
            count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            Console.WriteLine("Number of Node in the list: " + count);
        }

        public bool Search(object num)
        {
            int position = 1;
            Node current = head;
            while (current != null)
            {
                if (current.Data == num)
                    break;
                position++;
                current = current.Next;

            }
            if (current == null)
            {
                Console.WriteLine(num + " Not found in the list");
                return false;
            }
            else
            {
                Console.WriteLine(num + " at position " + position);
                return true;
            }

        }



        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index " + index);
            if (index > count)
                index = count;

            Node current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }
            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index " + index);
            if (this.Empty)
                return null;
            if (index > this.count)
                index = count - 1;

            Node current = this.head;
            object result = null;
            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;

            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }
    }
}
