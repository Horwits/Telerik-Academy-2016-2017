using System;
using System.Numerics;
using System.Text;

class Solution
{
    static BigInteger TwentyOneToDecimal(string twentyOneBased, string allLEtters)
    {
        BigInteger sum = 0;

        foreach (char digit in twentyOneBased)
        {
            var currentPos = allLEtters.IndexOf(digit);
            sum = (currentPos) + sum * 21;
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
            var num = TwentyOneToDecimal(input[i], allLetters);

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
