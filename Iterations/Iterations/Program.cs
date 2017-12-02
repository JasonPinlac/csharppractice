using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                
                if (i == 5)
                    continue;
                Console.WriteLine(i);

            }

            string name = "Jason Pinlac";

            for(int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();

            foreach(char c in name)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            // print even number from 0 to 100;

            int j = 0;

            while(j <= 100)
            {
                if(j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                String input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
                
            }
        }
    }
}
