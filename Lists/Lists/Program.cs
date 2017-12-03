using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4 };

            // Add and AddRange
            listOfNumbers.Add(5);
            listOfNumbers.AddRange(new int[] { 6, 7, 8 });

            foreach(int number in listOfNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // IndexOf and LastIndexOf
            int n = listOfNumbers.IndexOf(1);
            Console.WriteLine("Index of 1: " + n);
            int n2 = listOfNumbers.LastIndexOf(3);
            Console.WriteLine("Last index of 3: " + n2);

            // Count
            Console.WriteLine("Count of elements: " + listOfNumbers.Count);

            // Remove
            listOfNumbers.Remove(1);

            foreach (int num in listOfNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            listOfNumbers.RemoveAt(0);
            foreach (int num in listOfNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for(int i = 0; i < listOfNumbers.Count; i++)
            {
               
                if(listOfNumbers[i] == 6)
                {
                    listOfNumbers.RemoveAt(i);
                }
                
            }

            foreach (int num in listOfNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            listOfNumbers.Clear();
            foreach (int num in listOfNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(listOfNumbers.Count);


        }
    }
}
