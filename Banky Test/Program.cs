using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banky_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "Adebola goes to Adebola school Adebola goes to Adebola school Adebola goes to Adebola school Adebola goes to Adebola school";

            //create an array 
            //put each word in them
            // count each word reoccurence
            // display the highest occurence count.

            string[] wordArray = new string[] { };

            wordArray = Sentence.Split(' ');

         //   var f = wordArray.Where(w => w == "Adebola");
            var newWrod= wordArray.Distinct();
            List<WordCount> wordCountsList = new List<WordCount>();
            int highestCount = 0;
            foreach (var word in newWrod)
            {
                int currentCount = Array.FindAll(wordArray, W => W.ToLower() == word.ToLower()).Count();
                highestCount = currentCount > highestCount ? currentCount : highestCount;
                WordCount wordCount = new WordCount();
                wordCount.word = word;              
                wordCount.count = currentCount;              
                wordCountsList.Add(wordCount);   
            }

            string HighestCountWord = wordCountsList.Where(W => W.count == highestCount).FirstOrDefault().word;

            Console.WriteLine($"Highest Count word is {HighestCountWord} which occurs {highestCount} times");
            Console.Read();
        }

        class WordCount
        {
            public string word { get; set; }
            public int count { get; set; }
        }
    }
}
