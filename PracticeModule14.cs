using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Statistic
            string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            var words = GetWords(text);

            var wordCounts = CountWords(words);

            DisplayStatistics(wordCounts);

            Console.ReadLine();
        }
        static List<string> GetWords(string text)
        {
            return text.Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLower())
                .ToList();
        }

        static Dictionary<string, int> CountWords(List<string> words)
        {
            var wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            return wordCounts;
        }

        static void DisplayStatistics(Dictionary<string, int> wordCounts)
        {
            Console.WriteLine("Word\t\tCount");
            Console.WriteLine();
            foreach (var kvp in wordCounts)
            {
                Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
            }
        }
    }
}
