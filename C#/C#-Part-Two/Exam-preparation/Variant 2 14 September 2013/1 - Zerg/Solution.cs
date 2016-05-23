using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main()
    {
        var digitsToValues = new List<string>();
        digitsToValues.Add("Rawr");
        digitsToValues.Add("Rrrr");
        digitsToValues.Add("Hsst");
        digitsToValues.Add("Ssst");
        digitsToValues.Add("Grrr");
        digitsToValues.Add("Rarr");
        digitsToValues.Add("Mrrr");
        digitsToValues.Add("Psst");
        digitsToValues.Add("Uaah");
        digitsToValues.Add("Uaha");
        digitsToValues.Add("Zzzz");
        digitsToValues.Add("Bauu");
        digitsToValues.Add("Djav");
        digitsToValues.Add("Myau");
        digitsToValues.Add("Gruh");

        var numberToConvert = Console.ReadLine();

        int pos = 0;
        int i = 0;

        int length = numberToConvert.Length;
        int breakCounter = 0;

        BigInteger sum = 0;
        var indexOfCurrentDigit = 0;
        var copy = new StringBuilder(numberToConvert);
        int radix = 15;
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
