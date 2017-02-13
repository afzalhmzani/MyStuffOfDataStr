using System;

namespace MyStuffOfDataStr
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            //Console.ReadKey();
            SingleLinkedList list = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
            //list.InsertAtTheBiginneng(4);
            //list.InsertAtTheEnd(5);

            //Console.WriteLine("Is it empty " + list.Empty);
            //Console.WriteLine("The size ");
            //list.CountNode();
            //list.Search(1);
            Console.WriteLine("first one ");
            list.DisplayList();
            Console.WriteLine("list two ");
            list2.DisplayList();
            //list.InsertAtPosition(6, 3);
            //list.DisplayList();
            //Console.WriteLine(" the count is " + list.Count);
            Console.WriteLine("after marge:");
            list.Concatenate(list2);
            list.DisplayList();
            //list.ReverseList();

            //list.BubbleSortExData();
            //list.DisplayList();

            Console.ReadKey();


            //list.Remove(1);

        }
    }
}
