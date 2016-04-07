using System;
using System.Numerics;

class EncodingSum
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        BigInteger result = 0;
        foreach (char symbol in text)
        {
            if (symbol == '@')
            {
                break;
            }
            else if (char.IsDigit(symbol))
            {
                int currentNumber = symbol - '0';
                result *= currentNumber;
            }
            else if (char.IsLetter(symbol))
            {
                char currentLetter = char.ToUpper(symbol);
                result += currentLetter - 'A';
            }
            else
            {
                result %= m;
            }
        }

        Console.WriteLine(result);
    }
}
