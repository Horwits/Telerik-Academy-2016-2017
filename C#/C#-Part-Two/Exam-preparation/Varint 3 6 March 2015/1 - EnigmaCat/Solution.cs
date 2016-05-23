using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static BigInteger SeventeenToDecimal(string seventeenBased, string allLEtters)
    {
        BigInteger sum = 0;

        foreach (char digit in seventeenBased)
        {
            var currentPos = allLEtters.IndexOf(digit);
            sum = (currentPos) + sum * 17;
        }

        return sum;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        var allLetters = "abcdefghijklmnopqrstuvwxyz";
        var output = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            var num = SeventeenToDecimal(input[i], allLetters);

            var result = string.Empty;
            while (num > 0)
            {
                int currentDigit = (int)(num % 26);

                result = allLetters[currentDigit] + result;

                num /= 26;
            }

            output.Append(result).Append(' ');
        }

        Console.WriteLine(output.ToString().TrimEnd());
    }
}
