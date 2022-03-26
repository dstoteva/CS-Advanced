using System;
using System.IO;

namespace P01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialSymbols = "-.,?!";
            int counter = 0;
            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                
                using (var writer = new StreamWriter(@"../../../output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        
                        if (counter % 2 == 0)
                        {
                            if (counter != 0)
                            {
                                writer.WriteLine();
                            }
                            string newLine = string.Empty;
                            foreach (var ch in line)
                            {
                                if (specialSymbols.Contains(ch))
                                {
                                    newLine += '@';
                                }
                                else
                                {
                                    newLine += ch;
                                }
                            }
                            string[] splitted = newLine.Split();
                            Array.Reverse(splitted);

                            writer.Write(string.Join(" ", splitted));
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
