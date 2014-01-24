using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BMPReader
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 1)
            {
                if (File.Exists(args[0]))
                {
                    FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);

                    char c = br.ReadChar();
                    if (c == 'B')
                    {
                        c = br.ReadChar();
                        if (c == 'M')
                        {
                            Console.WriteLine(fs.Name + "file Information :"); Console.ReadKey();
                            Console.WriteLine(" _Magic Number is valid.");
                            int w = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                br.ReadInt32();
                            }
                            int j;
                            Console.WriteLine(" _Dimensions : " + br.ReadInt32() + "x" + br.ReadInt32());
                            j = br.ReadInt16();
                            Console.WriteLine(" _Number of bits per pixel: " + br.ReadInt16()); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(fs.Name); Console.Write(" : This file not an bitmap (BMP) file"); Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid"); Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Error: The File is invalid");
                    Console.WriteLine("Usage: bmpreader.exe <file.bmp>");
                    Console.ReadKey();
                }

            }
        }
    }
}
