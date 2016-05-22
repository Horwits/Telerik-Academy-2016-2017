using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    static List<string> ReorderWordPositions(List<string> words, int n)
    {
        for (int pos = 0; pos < words.Count; pos++)
        {
            string word = words[pos];
            int newPos = words[pos].Length % (words.Count + 1);
            words[pos] = null; // Mark the word for deleting
            words.Insert(newPos, word);
            words.Remove(null);
        }

        return words;
    }

    static int GetMaxLengthOfWordInArray(List<string> words, int wordsLength)
    {
        int max = 0;

        int currentLength = words[0].Length;
        for (int i = 1; i < wordsLength; i++)
        {
            max = Math.Max(currentLength, max);
            currentLength = words[i].Length;
        }

        return max;
    }

    static void PrintOperation(List<string> words)
    {
        var result = new StringBuilder();

        int currentLetterPos = 0;
        int maxLength = GetMaxLengthOfWordInArray(words, words.Count);

        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > currentLetterPos)
                {
                    result.Append(word[currentLetterPos]);
                }
                else
                {
                    continue;
                }
            }

            currentLetterPos++;
        }
        Console.WriteLine(result.ToString());
    }

    static void Main()
    {
        //using (var reader = new StreamReader(@"..\..\input.txt"))
        //{
        var n = int.Parse(Console.ReadLine());
        var words = new List<string>(n);

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        if (words.Count > 1)
        {
            words = ReorderWordPositions(words, n);

            PrintOperation(words);
        }
        else
        {
            Console.WriteLine(words[0]);
        }
        //}
    }
}
