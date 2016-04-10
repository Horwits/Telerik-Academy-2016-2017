using System;
using System.Text;

class DigitReverser
{
    static void PrintReversedNumberToConsole(decimal number)
    {
        Console.WriteLine(ReverseNumber(number));
    }

    static decimal ReverseNumber(decimal number)
    {
        var numberToString = number.ToString().ToCharArray();
        var reversedToString = new StringBuilder();

        int length = numberToString.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            reversedToString.Append(numberToString[i]);
        }

        number = decimal.Parse(reversedToString.ToString());

        return number;
    }

    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        PrintReversedNumberToConsole(number);
    }
}
