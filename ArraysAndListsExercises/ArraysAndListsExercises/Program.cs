using System;
using System.Collections.Generic;

namespace ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // problem1();
            //problem2();
            //problem3();
            //problem4();
            problem5();
        }

        static void problem1()
        {
            List<String> friends = new List<String>();
            String input;
            
            Console.WriteLine("Enter the names of your friends.");
            input = Console.ReadLine();
            while (input != "")
            {
                friends.Add(input);
                input = Console.ReadLine();
            }

            if(friends.Count == 0)
            {
                Console.WriteLine("No friends.");
            } else if (friends.Count == 1)
            {
                Console.WriteLine("{0} liked your post.", friends[0]);
            } else if (friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", friends[0], friends[1]);
            } else
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", friends[0], friends[1], friends.Count-2);
            }
        }

        static void problem2()
        {
            Console.Write("Enter you name: ");

            String input = Console.ReadLine();

            char[] arrayOfCharacters = input.ToCharArray();
            Array.Reverse(arrayOfCharacters);

            foreach(char c in arrayOfCharacters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        static void problem3()
        {
            Console.Write("Enter 5 numbers: ");
            List<int> numbers = new List<int>();
            int count = 0;
            while(count < 5)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Error, please retry a diffrent number.");
                }
                else
                {
                    numbers.Add(input);
                    count++;
                }
            }
            numbers.Sort();
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
        }

        static void problem4()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Repeatedly enter a number or type \"quit\" to exit.");
            while (true)
            {
                String input = Console.ReadLine();
                if(input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            List<int> uniques = new List<int>();
            foreach(int num in numbers)
            {
                if (!uniques.Contains(num))
                {
                    uniques.Add(num);
                }
            }

            foreach(int num in uniques)
            {
                Console.Write(num + " ");
            }
        }

        static void problem5()
        {
            String[] numbers;
            Console.Write("Enter a list of comma separated values: ");
            while (true)
            {
                String input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    numbers = input.Split(',');
                    if(numbers.Length >= 3)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid list! Re-try.");
            }
            List<int> listOfNumbers = new List<int>();
            foreach(string s in numbers)
            {
                listOfNumbers.Add(Convert.ToInt32(s));
            }

            List<int> smallest = new List<int>();

            

            while(smallest.Count < 3)
            {
                int min = listOfNumbers[0];
                foreach (int n in listOfNumbers)
                {
                    if (n < min)
                    {
                        min = n;
                    }
                }
                smallest.Add(min);
                listOfNumbers.Remove(min);
            }

            Console.Write("The three smallest numbers are: ");
            foreach (int n in smallest)
            {
                Console.Write(n + " ");
            }
            
            
            
        }
    }

}
