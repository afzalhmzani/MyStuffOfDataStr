using System;

namespace CircularLinkedListProject
{
    class CircularLinkedListDemo
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            CircularLinkedList CList = new CircularLinkedList();
            CircularLinkedList clist2 = new CircularLinkedList();

            CList.CreatList();
            clist2.CreatList();

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
                Console.WriteLine("9. concatnate");
                Console.WriteLine("10. Quit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 10)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("one");
                        CList.DisplayList();
                        Console.WriteLine("two");
                        clist2.DisplayList();
                        break;
                    case 2:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertInBeginning(data);
                        break;
                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        CList.InsertAfter(data, x);
                        break;
                    case 6:
                        CList.DeleteFirstNode();
                        break;
                    case 7:
                        CList.DeleteLastNode();
                        break;
                    case 8:
                        Console.Write("Enter an element to be deleted it: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        CList.DeleteNode(data);
                        break;
                    case 9:
                        Console.Write("concatnate two Clist");
                        CList.Concatenate(clist2);
                        CList.DisplayList();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
