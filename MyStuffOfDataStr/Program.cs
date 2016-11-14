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

            //Console.WriteLine("Is it empty " + list.Empty);
            Console.WriteLine("The size ");
            list.CountNode();
            list.Search(1);
            Console.ReadKey();


            //list.Remove(1);

        }
    }
}
