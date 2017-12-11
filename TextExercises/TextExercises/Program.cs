using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            Problem5();
        }

        public static void Problem1()
        {
            Console.WriteLine("Enter a few numbers separated by hyphon: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split('-');
            List<int> listOfNumbers = new List<int>();

            foreach (string n in numbers)
            {
                listOfNumbers.Add(Convert.ToInt32(n));
            }

            bool isConsecutive = true;

            listOfNumbers.Sort();

            for (int i = 1; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] != (listOfNumbers[i - 1]) + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            string result = (isConsecutive ? "Yes, consecutive!" : "No, not consecutive.");
            Console.WriteLine(result);
        }

        public static void Problem2()
        {
            Console.WriteLine("Enter a few numbers separated by hyphens: ");
            string input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;
            else
            {
                List<int> listOfNumbers = new List<int>();
                
                bool hasDuplicates = false;
                string[] arrayOfNumbers = input.Split('-');
                foreach (string s in arrayOfNumbers)
                {
                    int number = Convert.ToInt32(s);
                    if (listOfNumbers.Contains(number))
                        hasDuplicates = true;
                    else
                    {
                        listOfNumbers.Add(number);
                    }
                }
                string res = hasDuplicates ? "Duplicates!" : "No duplicates.";
                Console.WriteLine(res);
            }

        }

        public static void Problem3()
        {
            List<int> nums = new List<int>();
            DateTime time = new DateTime();

            bool isValidTime = true;
            Console.WriteLine("Enter a time value in the 24 hour format: I.E. '24:00'");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
 
            string[] timeComponents = input.Split(':');
            if (timeComponents.Length != 2)
            {
                isValidTime = false;
            }
            else
            {
                try
                {
                    int hour = Convert.ToInt32(timeComponents[0]);
                    int minute = Convert.ToInt32(timeComponents[1]);
                    if (hour <= 23 && hour >= 0 && minute <= 59 && minute >= 0)
                    {
                        time = time.AddHours(hour);
                        time = time.AddMinutes(minute);
                    }
                    else
                    {
                        isValidTime = false;
                    }
                    
                }
                catch (Exception e)
                {
                    isValidTime = false;
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("Time validity: {0} : {1}:{2}", isValidTime, time.Hour, time.Minute);
            
        }

        public static void Problem4()
        {
            Console.WriteLine("Enter a few words separated by spaces.");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            StringBuilder resultVariable = new StringBuilder();
            string[] words = input.Split(' ');
            foreach (string s in words)
            {
                resultVariable.Append(s.First().ToString().ToUpper() + s.Substring(1).ToLower());
            }
            Console.WriteLine(resultVariable.ToString());
        }

        public static void Problem5()
        {
            Console.WriteLine("Enter an english word: ");
            string input = Console.ReadLine();
            input =  input.ToLower();
            int vowelCount = 0;
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

            foreach (char c in input)
            {
                foreach (char v in vowels)
                {
                    if (c == v)
                    {
                        vowelCount++;
                    }
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
