using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Solution
{
    static string ExcelColumnIndexToName(int Index)
    {
        string range = string.Empty;
        if (Index < 0) return range;
        int a = 26;
        int x = (int)Math.Floor(Math.Log((Index) * (a - 1) / a + 1, a));
        Index -= (int)(Math.Pow(a, x) - 1) * a / (a - 1);
        for (int i = x + 1; Index + i > 0; i--)
        {
            range = ((char)(65 + Index % a)).ToString() + range;
            Index /= a;
        }
        return range;
    }

    static List<string> GenerateNumbers()
    {
        var numbers = new List<string>(168);
        var currentNumber = new StringBuilder();
        for (int i = 0; i < 168; i++)
        {
            if (i >= 26)
            {
                currentNumber.Append(ExcelColumnIndexToName(i));
                char toBeReplaced = currentNumber[0];
                currentNumber.Replace(toBeReplaced, char.ToLower(toBeReplaced), 0, 1);
                numbers.Add(currentNumber.ToString());

                currentNumber.Clear();
            }
            else
            {
                numbers.Add(ExcelColumnIndexToName(i));
            }
        }

        return numbers;
    }


    static void Main()
    {
        var digitsToValues = GenerateNumbers();//new Dictionary<string, int>();

        var numberToConvert = Console.ReadLine();

        int pos = 0;
        int i = 0;

        int length = numberToConvert.Length;
        int breakCounter = 0;

        BigInteger sum = 0;
        var indexOfCurrentDigit = 0;
        var copy = new StringBuilder(numberToConvert);

        //when using this code -> change the radix
        int radix = 168;

        while (true)
        {
            indexOfCurrentDigit = numberToConvert.IndexOf(digitsToValues[i]);

            if (indexOfCurrentDigit == pos)
            {
                numberToConvert = copy.Replace(digitsToValues[i], "@", pos, digitsToValues[i].Length).ToString();
                breakCounter += digitsToValues[i].Length;
                sum = i + sum * radix;
                pos++;

                i = 0;
            }
            else
            {
                i++;
            }

            if (breakCounter == length)
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}
