using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        //my mistake was that i didn't add zeroes at the gefining (the pad left part)
        var numbers = string.Join("",Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => Convert.ToString(int.Parse(x), 2).PadLeft(8, '0'))
                        .ToArray());

        var decoded = numbers
                        .Split(new[] { '0' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Length).ToArray();

        var lines = int.Parse(Console.ReadLine());

        int resultLength = decoded.Length;
        var result = new char[resultLength];
        for (int i = 0; i < lines; i++)
        {
            var currentLine = Console.ReadLine();
            var currentLineExtractedNumber = currentLine.Substring(1);
            var index = Array.IndexOf(decoded, int.Parse(currentLineExtractedNumber));
            while (index != -1)
            {
                decoded[index] = 0;
                result[index] = currentLine[0];

                index = Array.IndexOf(decoded, int.Parse(currentLineExtractedNumber));
            }
        }

        Console.WriteLine(result);
    }
}
