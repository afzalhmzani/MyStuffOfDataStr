using System;

namespace QueueProject
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            int choice, x;
            QueueA queueA = new QueueA(10);

            while (true)
            {
                Console.WriteLine("1. Insert an element on the queue.");
                Console.WriteLine("2. Delete an element from the queue.");
                Console.WriteLine("3. Display the top element in the queue.");
                Console.WriteLine("4. Display all element in the queue. ");
                Console.WriteLine("5. Display size of the queue.");
                Console.WriteLine("6. Quit.");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the elemnt to be pushed: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        queueA.Insert(x);
                        break;
                    case 2:

                        x = queueA.Delete();
                        Console.WriteLine("Deleted element is: " + x);
                        break;
                    case 3:
                        Console.WriteLine("The element at the top is " + queueA.Peek());
                        break;
                    case 4:

                        queueA.Display();
                        break;
                    case 5:
                        Console.WriteLine("The size of the stack is: " + queueA.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
