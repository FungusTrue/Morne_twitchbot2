using System;

namespace Morne_twitchbot2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Counter to count cutes
            int cuteCounter = 0;

            while (true)
            {
                //test input
                string test = Console.ReadLine();

                //Check text for a word
                WordSearch(test, "cute", ref cuteCounter);

                //write out test 
                Console.WriteLine(cuteCounter);
            }

        }

        static void WordSearch(string message, string checkWord, ref int checkWordCount)
        {

            Console.WriteLine(message);
            string[] words = message.Split(" ");

            foreach (var word in words)
            {
                if (word.ToLower() == checkWord)
                {
                    checkWordCount++;
                }
            }
        }

    }
}
