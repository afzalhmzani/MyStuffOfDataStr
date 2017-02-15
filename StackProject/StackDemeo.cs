using System;

namespace StackProject
{
    class StackDemeo
    {
        static void Main(string[] args)
        {
            int choice, x;
            StackA stackA = new StackA(8);
            StackL stackL = new StackL();

            while (true)
            {
                Console.WriteLine("1. Push an element on the stack.");
                Console.WriteLine("2. Pop an element from the stack.");
                Console.WriteLine("3. Display the top element in the stack.");
                Console.WriteLine("4. Display all element in the stack. ");
                Console.WriteLine("5. Display size of the stack.");
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
                        //stackA.Push(x); // array in a stack
                        stackL.Push(x);
                        break;
                    case 2:
                        //x = stackA.Pop(); //array in stack 
                        x = stackL.Pop();
                        Console.WriteLine("Popped element is: " + x);
                        break;
                    case 3:
                        Console.WriteLine("The element at the top is " + stackL.Peek());
                        break;
                    case 4:
                        //stackA.Display(); // array in stack to dispaly
                        stackL.Display();
                        break;
                    case 5:
                        Console.WriteLine("The size of the stack is: " + stackL.Size());
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
