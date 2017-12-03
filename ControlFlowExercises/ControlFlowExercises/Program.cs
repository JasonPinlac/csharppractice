using System;


namespace ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //question1();
            //question2();
            //question3();
            //question4();
            question5();
        }


        private static void question1()
        {
            //count how many numbers between 0 and 100 are divisble by 3 with no remainder.
            int count = 0;
            for(int i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine();
        }

        private static void question2()
        {
            int sum = 0;
            Console.WriteLine("Continuously enter a number or \"ok\" to stop.");
            String input;
            do
            {
                input = Console.ReadLine();
                if (input != "ok")
                sum += Convert.ToInt32(input);
            } while (input != "ok");
            Console.WriteLine("The sum is {0}.", sum);
        }

        private static void question3()
        {
            Console.Write("Enter a number: ");
            String input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(number + "!" + " = " + factorial(number));
        }

        private static int factorial(int n)
        {
            if(n > 0)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }

        private static void question4()
        {
            Random rand = new Random();
            int numberOfLives = 4;
            int numberToGuess = rand.Next(1, 11);
            int guessNumber = 1;
            Console.WriteLine("Guess a number between 1 and 10. You have 4 guesses.");
            while(numberOfLives > 0)
            {
                Console.WriteLine("Guess {0}: ", guessNumber);
                String input = Console.ReadLine();
                int guess = int.Parse(input);
                if(guess == numberToGuess)
                {
                    Console.WriteLine("You got it!");
                    break;
                }
                else
                {
                    numberOfLives--;
                }
                guessNumber++;
            }
            if(numberOfLives == 0){
                Console.WriteLine("Game over. You've run out of guesses.");
            }
        }

        private static void question5()
        {
            Console.WriteLine("Enter a series of number followed by commas.");
            String input = Console.ReadLine();

            Console.WriteLine(input);

            char[] delimiters = new char[]{ ' ', ',' };
            String[] arrayOfNumbers = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            int greatest = 0;
            foreach(string s in arrayOfNumbers)
            {
                int number = int.Parse(s);
                if(number >= greatest)
                {
                    greatest = number;
                }
            }
            Console.WriteLine("Greatest number is {0}.", greatest);
        }
    }
}
