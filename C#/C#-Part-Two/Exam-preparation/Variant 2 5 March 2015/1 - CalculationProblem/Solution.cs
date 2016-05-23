using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static long TwentyThreeToDecimal(string number)
    {
        long sum = 0;

        foreach (char digit in number)
        {
            sum = (digit - 'a') + sum * 23;
        }

        return sum;
    }

    static string ConvertDecimalToNineteenBased(long number)
    {
        var result = string.Empty;
        while (number != 0)
        {
            int currentDigit = (int)(number % 23);

            string allNumbers = "abcdefghijklmnopqrstuvwxyz";

            result = allNumbers[currentDigit] + result;

            number /= 23;
        }

        return result;
    }

    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ');
        var result = 0L;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += TwentyThreeToDecimal(numbers[i]);
        }

        Console.WriteLine("{0} = {1}", ConvertDecimalToNineteenBased(result), result);
    }
}
