using System;

class HexadecimalToDecimalConverter
{
    static long ConvertHexToDecimal(string hex)
    {
        long result = 0;
        int currentPosition = 0,
            length = hex.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            char currentChar = hex[i];
            var currentNum = 0;
            if (currentChar >= '0' && currentChar <= '9')
            {
                currentNum = currentChar - '0';
            }
            else
            {
                currentNum = currentChar - 'a' + 10;
            }

            result += (currentNum * (long)Math.Pow(16, currentPosition));
            currentPosition++;
        }

        return result;
    }

    static void Main()
    {
        var hex = Console.ReadLine().ToLower();

        var result = ConvertHexToDecimal(hex);
        Console.WriteLine(result);
    }
}
