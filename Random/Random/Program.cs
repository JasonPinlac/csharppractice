using System;


namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write((char) ('a' + rand.Next(0,26)));
            }
            Console.WriteLine();

        }
    }
}
