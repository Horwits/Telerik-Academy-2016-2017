using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SenteceExtractor
{
    static int GetIndexOfStringInString(string text, string word)
    {
        int indexOfWord = text.IndexOf(word);
        while (indexOfWord != -1)
        {
            if (indexOfWord == 0)
            {
                if (text[indexOfWord + word.Length] == ' ')
                {
                    return indexOfWord;
                }
            }
            else if (indexOfWord > 0 && indexOfWord + word.Length < text.Length)
            {
                if (text[(indexOfWord - 1)] == ' ' && text[indexOfWord + word.Length] == ' ')
                {
                    return indexOfWord;
                }
            }
            else if (indexOfWord + word.Length == text.Length)
            {
                if (text[indexOfWord - 1] == ' ')
                {
                    return indexOfWord;
                }
            }

            indexOfWord = text.IndexOf(word, ++indexOfWord);
        }

        return indexOfWord;
    }

    static string RemoveEverySymbolExceptLetterAndAddWhiteSpace(string text)
    {
        var sb = new StringBuilder();

        foreach (char c in text)
        {
            if (!char.IsLetter(c))
                sb.Append(' ');
            else
                sb.Append(c);
        }

        return sb.ToString();
    }

    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        var splittedToSenteces = text
            .Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        //var result = new StringBuilder();
        for (int i = 0; i < splittedToSenteces.Length; i++)
        {
            //var punctuation = splittedToSenteces[i].Where(Char.IsPunctuation).Distinct().ToArray();

            var currentSentenceToWords = RemoveEverySymbolExceptLetterAndAddWhiteSpace(splittedToSenteces[i]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var cleanSentence = RemoveEverySymbolExceptLetterAndAddWhiteSpace(splittedToSenteces[i]).ToLower();

            var indexOfPattern = GetIndexOfStringInString(cleanSentence, pattern.ToLower());

            var isOccured = indexOfPattern != -1;

            if (isOccured)
            {
                Console.Write(splittedToSenteces[i] + '.');
                continue;
            }

            //foreach (var word in currentSentenceToWords)
            //{
            //    var currWord = word.Replace(word[0], char.ToUpper(word[0]));
            //    //if (word == pattern || word.ToUpper() == pattern || word.ToLower() == pattern || currWord == pattern)
            //
            //    if (word.ToLower() == pattern.ToLower())
            //    {
            //        //result.Append(splittedToSenteces[i]).Append('.');
            //        Console.Write(splittedToSenteces[i] + '.');
            //        break;
            //    }
            //}
        }

        //Console.WriteLine(result.ToString());
    }
}