using System;
using System.Text;

class BinaryShortGenerator
{
    static string ReverseString(string input)
    {
        int length = input.Length;
        var result = new StringBuilder();
        for (int i = length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        return result.ToString();
    }

    static string ConvertFromShortToBinary(short n)
    {
        var copyN = n;
        var appender = new StringBuilder();

        for (int i = 0; i < 16; i++)
        {
            var digit = copyN % 2;
            if (n < 0)
            {
                if (digit == 0)
                {
                    appender.Append(1);
                }
                else
                {
                    appender.Append(0);
                }
            }
            else
            {
                appender.Append(digit);

            }

            copyN /= 2;
        }

        var negativeResult = ReverseString(appender.ToString());
        if (n < 0)
        {
            int number_one = Convert.ToInt32(negativeResult, 2);
            int number_two = Convert.ToInt32("0000000000000001", 2);
            return (Convert.ToString(number_one + number_two, 2));
        }

        return negativeResult;
    }

    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        Console.WriteLine(ConvertFromShortToBinary(n));
    }
}
