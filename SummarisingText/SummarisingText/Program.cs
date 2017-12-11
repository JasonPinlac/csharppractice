using System;
using SummarisingText;


namespace com.jasonpinlac
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is fun whoa";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 25));
        }

    }
}
