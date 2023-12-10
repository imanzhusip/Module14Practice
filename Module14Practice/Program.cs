using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> wordCount = CountWords(text);

            Console.WriteLine("Слова и их количество в тексте:");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.ReadKey();
        }
        static Dictionary<string, int> CountWords(string text)
        {
            string[] words = text.Split(new[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string normalizedWord = word.ToLower();
                if (wordCount.ContainsKey(normalizedWord))
                {
                    wordCount[normalizedWord]++;
                }
                else
                {
                    wordCount[normalizedWord] = 1;
                }
            }
            return wordCount;
        }
    }

}
