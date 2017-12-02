using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            bool[] booleans = { true, false };
            int[] morenumbers = { 1, 2, 3 };

            char[] names = new char[3];

            foreach (char s in names)
            {
                Console.WriteLine(s);
            }

            var myNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            foreach(int n in myNumbers)
            {
                Console.WriteLine(n);
            }

            foreach (int n in morenumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(booleans.Length);

            foreach (bool b in booleans)
            {
                Console.WriteLine(b);
            }
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
