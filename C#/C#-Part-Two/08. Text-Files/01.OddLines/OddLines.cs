using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"..\..\reader.txt");

        int length = lines.Length;
        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("{0}.{1}", i, lines[i]);
            }
        }
    }
}
