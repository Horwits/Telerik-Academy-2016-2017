using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Solution
{
    static void Main()
    {
        var digitsToValues = new List<string>();//new Dictionary<string, int>();
        digitsToValues.Add("f");//, 0);
        digitsToValues.Add("bIN");//, 1);
        digitsToValues.Add("oBJEC");//, 2);
        digitsToValues.Add("mNTRAVL");//, 3);
        digitsToValues.Add("lPVKNQ");//, 4);
        digitsToValues.Add("pNWE");//, 5);
        digitsToValues.Add("hT");//, 6);

        var numberToConvert = Console.ReadLine();
       
        int pos = 0;
        int i = 0;

        int length = numberToConvert.Length;
        int breakCounter = 0;

        BigInteger sum = 0;
        var indexOfCurrentDigit = 0;
        var copy = new StringBuilder(numberToConvert);
        int radix = 7;
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
