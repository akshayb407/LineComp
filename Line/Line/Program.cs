using System;

namespace Line
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello,Welcome to LineComparision");

            Console.WriteLine("===========UC1===========");
            UC1 u1 = new UC1();
            u1.Length();


            Console.WriteLine("===========UC2===========");
            UC2 u2 = new UC2();
            u2.EqualityOfLines();

            Class1.DisplayMessage();

        }



    }
}
