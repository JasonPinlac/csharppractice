using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jason";
            string lastName = "Pinlac";
            string fullName = firstName + " " + lastName;

            string fullName2 = string.Format("{0} {1}", firstName, lastName);
            string output = string.Format("{0}", "I Love Turtles!!!");
            Console.WriteLine(output);

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);


            var numbers = new int[3] { 1, 2, 3 };
            var booleans = new bool[5];

            string boolResults = string.Join(".", booleans);
            Console.WriteLine(boolResults);

            string stringNumbers = string.Join(",", numbers);
            Console.WriteLine(stringNumbers);


            string name = "Jason";
            char firstChar = name[0];
            char secondChar = "Jason"[1];
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            


        }
    }
}
