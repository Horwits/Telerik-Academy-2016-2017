using System;
using System.Text;

class Program
{
    static long ConvertNineteenBasedToDecimal(string input)
    {
        long result = 0;
        int currentPosition = 0,
            length = input.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            char currentChar = input[i];
            var currentNum = 0;

            if (currentChar != ' ')
            {
                currentNum = currentChar - 'a';
                result += (currentNum * (long)Math.Pow(19, currentPosition));
                currentPosition++;
            }
        }

        return result;
    }

    static string ConvertFromDecimalToNineteenBased(long number)
    {
        var nineTeenBasedResult = new StringBuilder();
        while (number != 0)
        {
            int currentDigit = (int)(number % 19);

            char currentChar = (char)(currentDigit + 'a');
            nineTeenBasedResult.Append(currentChar);

            number /= 19;
        }

        string result = nineTeenBasedResult.ToString();
        return result;
    }

    static string ReverseString(string toBeReversed)
    {
        var reversed = new StringBuilder();

        int length = toBeReversed.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            reversed.Append(toBeReversed[i]);
        }

        return reversed.ToString();
    }

    static void Main()
    {
        string input = Console.ReadLine();

        var splittedCode = input.Split(' ');

        long result = 0;

        foreach (var code in splittedCode)
        {
            result += ConvertNineteenBasedToDecimal(code);
        }

        string encripted = ConvertFromDecimalToNineteenBased(result);
        Console.WriteLine("{0} = {1}", ReverseString(encripted), result);
    }
}
