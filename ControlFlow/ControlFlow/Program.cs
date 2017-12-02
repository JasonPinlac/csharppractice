using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = 15;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning.");
            } else if (hour > 12 && hour <= 24)
            {
                Console.WriteLine("It is night.");
            } else
            {
                Console.WriteLine("It is afternoon.");
            }

            Season todaysSeason = Season.Winter;
            switch(todaysSeason)
            {
                case Season.Fall:
                    Console.WriteLine("The season is {0}.", Season.Fall);
                    break;
                case Season.Winter:
                    Console.WriteLine("The season is {0}.", Season.Winter);
                    break;
                case Season.Summer:
                    Console.WriteLine("The season is {0}.", Season.Summer);
                    break;
                case Season.Spring:
                    Console.WriteLine("The season is {0}.", Season.Spring);
                    break;
                default:
                    break;
            }

            bool isGoldDigger = true;

            float moneyToSpend = (isGoldDigger) ? 99.99f : 10.99f ;
            Console.WriteLine(moneyToSpend);
        }
    }
}
