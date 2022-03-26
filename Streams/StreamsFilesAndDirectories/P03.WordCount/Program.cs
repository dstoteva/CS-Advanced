using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            using (var wordReader = new StreamReader("../../../words.txt"))
            {
                string line;
                while ((line = wordReader.ReadLine()) != null)
                {
                    string[] splitted = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();
                    words.AddRange(splitted);
                }
            }

            var wordsDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict[word] = 0;
                }
            }
            using (var reader = new StreamReader("../../../text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string symbols = " ";
                    foreach (var ch in line)
                    {
                        if (char.IsPunctuation(ch) && ch != '\'')
                        {
                            symbols += ch;
                        }
                    }
                    string[] splitted = line.ToLower().Split(symbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splitted)
                    {
                        if (wordsDict.ContainsKey(word))
                        {
                            wordsDict[word]++;
                        }
                    }
                }
            }
            var sorted = wordsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            using (var readerResult = new StreamReader("../../../expectedResult.txt"))
            {
                bool isEqual = true;
                foreach (var kvp in sorted)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    string line = readerResult.ReadLine();

                    if (output != line)
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    Console.WriteLine(true);
                }
            }

            using (var writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var kvp in sorted)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
