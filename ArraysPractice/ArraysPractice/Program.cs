using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            // Length field returns the size of the array
            Console.WriteLine("\nLength of the array: " + numbers.Length);

            // IndexOf()
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            Array.Clear(numbers, 0, 2); // half-open

            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }

            // Copy
            Console.WriteLine();
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            foreach (int n in anotherArray)
            {
                Console.Write(n + " ");
            }

            // Sort
            Console.WriteLine();
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            // Reverse
            Console.WriteLine();
            Array.Reverse(numbers);
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
