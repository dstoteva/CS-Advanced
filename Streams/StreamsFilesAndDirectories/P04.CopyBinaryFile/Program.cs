﻿using System;
using System.IO;

namespace P04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                
                using (var writer = new FileStream("../../../copied.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead < 1)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, bytesRead);
                    }
                    
                }
            }
        }
    }
}
