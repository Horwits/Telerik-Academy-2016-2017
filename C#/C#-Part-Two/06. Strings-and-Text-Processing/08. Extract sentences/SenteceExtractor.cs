using System;
using System.Linq;

class SenteceExtractor
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        var splittedToSenteces = text
            .Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x + '.')
            .ToArray();

        bool isOccured = false;
        for (int i = 0; i < splittedToSenteces.Length; i++)
        {
            var splittedToWords = splittedToSenteces[i].Split(' ');

            foreach (var word in splittedToWords)
            {
                if (word == pattern)
                {
                    isOccured = true;
                    break;
                }
                else
                {
                    isOccured = false;
                }
            }

            if (isOccured)
            {
                Console.Write(splittedToSenteces[i]);
            }
        }

        Console.WriteLine();
    }
}
