using System;

namespace CircularLinkedListProject
{
    class CircularLinkedListDemo
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            CircularLinkedList CList = new CircularLinkedList();

            CList.CreatList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert in the beginning");
                Console.WriteLine("4. Insert in the end");
                Console.WriteLine("5. Insert after a node");
                Console.WriteLine("6. Delete first node");
                Console.WriteLine("7. Delete last node");
                Console.WriteLine("8. Delete any node");
                Console.WriteLine("9. Quit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 9)
                    break;
                switch (choice)
                {
                    case 1:
                        CList.DisplayList();
                        break;
                    case 2:
                        Console.Write("Enter the elemint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.Write("Enter the elemnt to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertInBeginning(data);
                        break;
                    case 4:
                        Console.Write("Enter the elemint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.Write("Enter the emint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the elemnt after which to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        CList.InsertAfter(data, x);
                        break;


                }

            }
        }
    }
}
