using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static string searchedWord;
    static int L;
    static string[] words;
    static Dictionary<int, string> result = new Dictionary<int, string>();

    static void ReadInput()
    {
        searchedWord = Console.ReadLine();
        L = int.Parse(Console.ReadLine());
        var currentLine = new StringBuilder();
        words = new string[L];

        for (int i = 0; i < L; i++)
        {
            var currentLineToArr = Console.ReadLine().Split(new char[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);//.Replace(searchedWord.ToLower(), searchedWord.ToUpper());

            CountOccurances(currentLineToArr);
        }
    }

    static void CountOccurances(string[] words)
    {
        int counter = 0;
        var length = words.Length;
        for (int i = 0; i < length; i++)
        {
            var item = words[i];
            if (item.ToLower() == searchedWord.ToLower())
            {
                counter++;
                words[i] = WordToUpper(item);
            }
        }

        result.Add(counter, string.Join(" ", words));
    }

    static string WordToUpper(string word)
    {
        return word.ToUpper();
    }

    static void Main()
    {
        ReadInput();

        var list = result.Keys.ToList();
        list.Sort();

        // Loop through keys.
        var length = list.Count;
        for (int i = length - 1; i >= 0; i--)
        {
            var key = list[i];
            Console.WriteLine(result[key]);
        }
    }
}