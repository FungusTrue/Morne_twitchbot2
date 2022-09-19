using System;

namespace Morne_twitchbot2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter to count cutes
            int cuteCounter = 0;
            //Tesst counters for users
            int Fungus = 0;
            int Morne9 = 0;
            while (true)
            {
                //test input
                string test = Console.ReadLine();
                string user = Console.ReadLine();
                //Count users earlier
                int userWordCount = 0;
                if (user == "1")
                {
                    userWordCount = Fungus;
                }
                else
                {
                    userWordCount = Morne9;
                }
                //Check text for a word
                WordSearch(test, "cute", ref cuteCounter, ref userWordCount);
                //Update user count
                if (user == "1")
                {
                    Fungus = userWordCount;
                }
                else
                {
                    Morne9 = userWordCount;
                }
                //write out test 
                Console.WriteLine(cuteCounter);
                Console.WriteLine($"Fungus = {Fungus}");
                Console.WriteLine($"Morne9 = {Morne9}");
            }
        }
        static void WordSearch(string message, string checkWord, ref int checkWordCount, ref int userWordCount)
        {
            //Split the message inte to seprate words
            string[] words = message.Split(" ");
            //Lopp to check each word if the match the check word
            foreach (var word in words)
            {
                if (word.ToLower() == checkWord)
                {
                    checkWordCount++;
                    userWordCount++;
                }
            }
        }
    }
}
