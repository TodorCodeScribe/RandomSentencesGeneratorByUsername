using System;
using System.Linq;
using System.Collections.Generic;

 
namespace RandomSentensesGenerator.cs
{

    class RandomSentencesGenerator
    {
       static string GetRandomWord(string[] words)
        {

            Random random = new Random();

            int randomIndex = random.Next(words.Length);

            string word = words[randomIndex];
            return word;

        }

        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };

            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };

            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };

            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };

            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };

            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this os your first random-generated sentence: ");

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlaces = GetRandomWord(places);
                string randomVerbs = GetRandomWord(verbs);
                string randomNouns = GetRandomWord(nouns);
                string randomAdverbs = GetRandomWord(adverbs);
                string randomDetails = GetRandomWord(details);

                string who = $"{randomName} from {randomPlaces}";
                string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {action} {randomDetails}.";

                
                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");

                // Изчакайте натискането на клавиш
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Проверете дали е натиснат клавишът Enter
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear(); // Изчистване на конзолата
                    continue; // Продължаване със следващата итерация на цикъла
                }

                break; // Ако не е натиснат Enter, излезте от цикъла
            }

           


        }
       

    }
   
}
