using System;


namespace QueueProject
{
    class QueueL
    {
        private QueNode front;
        private QueNode rear;

        public QueueL()
        {
            front = null;
            rear = null;
        }

        public int Size()
        {
            int s = 0;
            QueNode p = front;
            while (p != null)
            {
                s++;
                p = p.link;
            }
            return s;
        }

        public void Insert(int x)
        {
            QueNode temp;
            temp = new QueNode(x);
            if (front == null)
                front = temp;
            else
                rear.link = temp;
            rear = temp;

        }

        public int Delete()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            x = front.info;
            front = front.link;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Oueue Underflow");
            return front.info;
        }

        public bool IsEmpty()
        {
            return (front == null);
        }

        public void Display()
        {
            QueNode p = front;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Queue is: ");
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
