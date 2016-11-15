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
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1, "Test3");
            list.InsertAtTheBiginneng("testB");
            list.InsertAtTheEnd("testL");

            //Console.WriteLine("Is it empty " + list.Empty);
            Console.WriteLine("The size ");
            list.CountNode();
            list.Search(1);
            list.DisplayList();
            list.InsertAtPosition("pos", 3);
            list.DisplayList();
            Console.WriteLine(" the count is " + list.Count);

            list.ReverseList();

            list.DisplayList();
            Console.ReadKey();


            //list.Remove(1);

        }
    }
}
