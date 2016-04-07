using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();

        //alternative solution
        //foreach (var symbol in word)
        //{
        //    Console.WriteLine(symbol - 'a');
        //}

        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 'a');
        }

        int length = word.Length;

        for (int j = 0; j < length; j++)
        {
            var currentLetter = word[j];
            for (int i = 0; i < 26; i++)
            {
                if (currentLetter == letters[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
