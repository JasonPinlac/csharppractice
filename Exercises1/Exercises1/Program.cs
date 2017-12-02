using System;


namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            number1();
            number2();
            number4();

        }

        public static void number1()
        {
            bool isValid = true;
            do
            {
                Console.Write("Enter a number between 1 and 10 inclusive: ");
                int response = Convert.ToInt32(Console.ReadLine());

                if (response >= 0 && response <= 10)
                {
                    Console.WriteLine("Valid.");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            } while (isValid);
        }

        public static void number2()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        public static void number4()
        {
            Console.WriteLine("Enter the maximum speed limit allowed: ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of your car: ");
            int currentSpeed = Convert.ToInt32(Console.ReadLine());

            if(currentSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int speedOver = currentSpeed - speedLimit;
                int points = speedOver / 5;

                if(points > 12)
                {
                    Console.WriteLine("License suspended.");
                }
                else
                {
                    Console.WriteLine(points);
                }
            }
        }
    }
}
