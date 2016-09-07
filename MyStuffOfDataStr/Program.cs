namespace MyStuffOfDataStr
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            //Console.ReadKey();
            LinkedList list = new LinkedList();
            //Console.WriteLine("Is it empty " + list.Empty);
            //Console.WriteLine("The size " + list.Count);
            //Console.ReadKey();
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1, "Test3");
        }
    }
}
