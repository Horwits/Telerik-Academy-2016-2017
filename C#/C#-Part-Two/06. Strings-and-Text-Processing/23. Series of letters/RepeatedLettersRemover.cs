using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RepeatedLettersRemover
{
    static void Main()
    {
        string text = Console.ReadLine();

        var result = new StringBuilder();
        int length = text.Length;

        for (int i = 0, j = 1; i < length; i++, j++)
        {
            char currentChar = text[i];
            char nextChar = 'с';
            if (j < length)
            {
                nextChar = text[j];
            }

            if (currentChar == nextChar)
            {
                continue;
            }
            else
            {
                result.Append(currentChar);
                
            }
        }

        Console.WriteLine(result.ToString());
    }
}
