using System;
using System.IO;

namespace P02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int counter = 1;
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int letterCount = 0;
                        int symbolsCount = 0;

                        foreach (var ch in line)
                        {
                            if (char.IsLetter(ch))
                            {
                                letterCount++;
                            }
                            else if (char.IsPunctuation(ch))
                            {
                                symbolsCount++;
                            }
                        }
                        if (counter != 1)
                        {
                            writer.WriteLine();
                        }
                        writer.Write($"Line {counter}: {line} ({letterCount})({symbolsCount})");

                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
