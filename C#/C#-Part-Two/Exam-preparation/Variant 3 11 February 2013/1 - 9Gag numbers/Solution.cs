using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    public static List<string> numbers = new List<string>() { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

    static void Main()
    {
        var numberToConvert = Console.ReadLine();

        int pos = 0;
        int i = 0;

        int length = numberToConvert.Length;
        int breakCounter = 0;

        BigInteger sum = 0;
        var indexOfCurrentDigit = 0;
        var copy = new StringBuilder(numberToConvert);
        int radix = 9;
        while (true)
        {
            indexOfCurrentDigit = numberToConvert.IndexOf(numbers[i]);

            if (indexOfCurrentDigit == pos)
            {
                numberToConvert = copy.Replace(numbers[i], "@", pos, numbers[i].Length).ToString();
                breakCounter += numbers[i].Length;
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
