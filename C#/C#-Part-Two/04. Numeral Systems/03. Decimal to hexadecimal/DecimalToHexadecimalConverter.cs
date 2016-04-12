using System;
using System.Text;

class DecimalToHexadecimalConverter
{
    static string ConvertDecimalToHex(long number)
    {
        var reversedResult = new StringBuilder();
        while (number != 0)
        {
            int currentDigit = (int)(number % 16);
            if (currentDigit < 10)
            {
                reversedResult.Append(currentDigit);
            }
            else
            {
                switch (currentDigit)
                {
                    case 10: reversedResult.Append('A'); break;
                    case 11: reversedResult.Append('B'); break;
                    case 12: reversedResult.Append('C'); break;
                    case 13: reversedResult.Append('D'); break;
                    case 14: reversedResult.Append('E'); break;
                    case 15: reversedResult.Append('F'); break;
                }
            }

            number /= 16;
        }

        string result = reversedResult.ToString();
        return result;
    }

    static string ReverseString(string input)
    {
        var reversedResult = new StringBuilder();
        int length = input.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            reversedResult.Append(input[i]);
        }

        string result = reversedResult.ToString();
        return result;
    }

    static void Main()
    {
        //1000000000000000000
        long number = long.Parse(Console.ReadLine());

        var result = ConvertDecimalToHex(number);
        Console.WriteLine(ReverseString(result));
    }
}
