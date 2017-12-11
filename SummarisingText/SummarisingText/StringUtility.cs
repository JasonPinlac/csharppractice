using System;
using System.Collections.Generic;


namespace SummarisingText
{
    class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length > maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                totalCharacters += word.Length;
                totalCharacters += 1; // because of the space
                if (totalCharacters > maxLength)
                    break;

                summaryWords.Add(word);
            }

            return String.Join(" ", summaryWords);

        }

    }
}
