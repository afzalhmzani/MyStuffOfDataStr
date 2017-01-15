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
            list.Add(2);
            list.Add(3);
            list.Add(1);
            //list.Add(6);
            //list.Add(5);
            //list.Add(4);
            //list.InsertAtTheBiginneng(4);
            //list.InsertAtTheEnd(5);

            //Console.WriteLine("Is it empty " + list.Empty);
            Console.WriteLine("The size ");
            list.CountNode();
            //list.Search(1);
            list.DisplayList();
            //list.InsertAtPosition(6, 3);
            //list.DisplayList();
            //Console.WriteLine(" the count is " + list.Count);

            //list.ReverseList();

            list.BubbleSortExData();
            list.DisplayList();

            Console.ReadKey();


            //list.Remove(1);

        }
    }
}
