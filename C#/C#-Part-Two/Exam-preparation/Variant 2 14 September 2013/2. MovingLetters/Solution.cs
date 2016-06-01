using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static string input;
    static int maxLength;
    static string[] words;
    //static List<char> extractedWords;
    static StringBuilder extractedWords;

    static void ReadInput()
    {
        input = Console.ReadLine();
        words = input.Split(' ');//(new char[' '], StringSplitOptions.RemoveEmptyEntries);
    }

    static void FindMaxLengthOfWordsInString()
    {
        //var res = words.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        //maxLength = res.Length;
        maxLength = int.MinValue;
        foreach (var word in words)
        {
            int currentLength = word.Length;
            maxLength = Math.Max(currentLength, maxLength);
        }
    }

    static void ExtractWords()
    {
        //extractedWords = new List<char>();
        extractedWords = new StringBuilder();

        int counter = 0;
        var length = words.Length;

        while (counter < maxLength)
        {
            for (int i = 0; i < length; i++)
            {
                var currentWord = words[i];
                var currentPos = currentWord.Length - 1;

                if (currentPos - counter >= 0)
                {
                    //extractedWords.Add(currentWord[currentPos - counter]);
                    extractedWords.Append(currentWord[currentPos - counter]);
                }
            }

            counter++;
        }
    }

    static void MoveLetters()
    {
        int length = extractedWords.Length;//extractedWords.Count;

        //var copy = new List<char>();
        //    copy.AddRange(extractedWords);

        for (int i = 0; i < length; i++)
        {
            var currentSymbol = extractedWords[i];
            var K = (char.ToLower(currentSymbol) - 'a') + (i + 1);

            if (K >= length)
            {
                K %= length;
            }

            //extractedWords.RemoveAt(i);
            extractedWords.Remove(i, 1);
            extractedWords.Insert(K, currentSymbol);
        }
    }

    static void Main(string[] args)
    {
        //1. read input
        ReadInput();
        //2. extract words
        //2.1 ->  method for finding the maxlength
        FindMaxLengthOfWordsInString();
        //2.2 while -> and then when a counter reaches the maxLength breaks and returns the result
        ExtractWords();
        //3. move letters
        //3.1 --for -> 
        //==if K is bogger or equal to length %  the lenght of it,
        //--currentHolder of the value to be moved,
        //move it,
        //and for evry cycle of the for removeAt this pos
        MoveLetters();

        Console.WriteLine(extractedWords.ToString());
        //Console.WriteLine(string.Join("", extractedWords));
    }
}
