using System;

namespace DoubleLinkedListProject
{
    public class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            DoubleLinkedList dlist = new DoubleLinkedList();
            dlist.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert a node at the biginning of the list");
                Console.WriteLine("4. Insert a node at the end of the list");
                Console.WriteLine("5. Insert a node after a specifide node");
                Console.WriteLine("6. Insert a node before a specifide node");
                Console.WriteLine("7. Delete first node");
                Console.WriteLine("8. Delete last node");
                Console.WriteLine("9. Delete any node");
                Console.WriteLine("10. Reverse the list");
                Console.WriteLine("11. Quit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;
                switch (choice)
                {
                    case 1:
                        dlist.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Enter the eleimint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        dlist.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.WriteLine("Enter elemint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        dlist.InserInBeginning(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter an elemint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        dlist.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the elemeint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter elemeint after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        dlist.InsertAfter(data, x);
                        break;
                    case 6:
                        Console.WriteLine("Enter the elememint to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the elemint before wich to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        dlist.InsertBefor(data, x);
                        break;
                    case 7:
                        dlist.DeleteFirstNode();
                        break;
                    case 8:
                        dlist.DeleteLastNode();
                        break;
                    case 9:
                        Console.WriteLine("Enter an element to be deleted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        dlist.DeleteNode(data);
                        break;
                    case 10:
                        dlist.ReversList();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");


        }
    }
}
