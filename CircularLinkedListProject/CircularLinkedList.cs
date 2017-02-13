using System;

namespace CircularLinkedListProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }
            Node p = last.link;

            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            } while (p != last.link);

            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;

        }

        public void CreatList()
        {
            int i, n, data;

            Console.Write("Enter number of node: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            Console.Write("Enter the element to be iserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i < n; i++)
            {
                Console.Write("Enter the elemnt to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = last.link;
            do
            {
                if (p.info == x)
                    break;
                p = p.link;
            } while (p != last.link);
            if (p == last.link && p.info != x)
                Console.WriteLine(x + "the elemnt is not found");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
                if (p == last)
                    last = temp;
            }

        }

        public void DeleteFirstNode()
        {
            if (last == null)
                return;
            if (last.link == last)
            {
                last = null;
                return;
            }
            last.link = last.link.link;
        }

        public void DeleteLastNode()
        {
            if (last == null)
                return;
            if (last.link == last)
            {
                last = null;
                return;
            }
            Node p = last.link;
            while (p.link != last)
            {
                p = p.link;
            }
            p.link = last.link;
            last = p;
        }

        public void DeleteNode(int x)
        {
            if (last == null)
                return;
            if (last.link == last && last.info == x)
            {
                last = null;
                return;
            }
            if (last.link.info == x)
            {
                last.link = last.link.link;
                return;
            }
            Node p = last.link;
            while (p.link != last.link)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == last.link)
            {
                Console.WriteLine(x + "the element is not found");
            }
            else
            {
                p.link = p.link.link;
                if (last.info == x)
                    last = p;
            }
        }

        public void Concatenate(CircularLinkedList cList)
        {
            if (last == null)
            {
                last = cList.last;
                return;
            }
            if (cList.last == null)
            {
                return;
            }
            Node p = last.link;
            last.link = cList.last.link;
            cList.last.link = p;
            last = cList.last;
        }

    }
}
