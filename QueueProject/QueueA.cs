using System;

namespace QueueProject
{
    class QueueA
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public QueueA()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueA(int maxIndex)
        {
            queueArray = new int[maxIndex];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return (front == -1 || front == rear + 1);
        }

        public bool IsFull()
        {
            return (rear == queueArray.Length - 1);
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;
            else
            {
                return rear - front + 1;
            }
        }

        public void Insert(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow\n");
                return;
            }
            if (front == -1)
                front = 0;
            rear = rear + 1;
            queueArray[rear] = x;
        }

        public int Delete()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow");
            x = queueArray[front];
            front = front + 1;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow");
            return queueArray[front];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("Queue is: \n\n");
            for (int i = front; i <= rear; i++)
                Console.Write(queueArray[i] + " ");
            Console.WriteLine();
        }
    }
}
