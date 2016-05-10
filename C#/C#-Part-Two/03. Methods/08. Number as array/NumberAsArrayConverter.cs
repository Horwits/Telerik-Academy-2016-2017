using System;
using System.Text;

class NumberAsArrayConverter
{
    static void PrintNumberSeparatedBySpacesToConsole(string number)
    {
        var numberToArray = number.ToCharArray();
        Console.WriteLine(string.Join(" ", numberToArray));
    }

    static string CalculateTwoNumbersRepresentedAsArrays(string[] firstNumber, string[] secondNumber, short numberOneLength, short numberTwoLength)
    {
        var result = new StringBuilder();

        var maxLength = Math.Max(numberOneLength, numberTwoLength);

        short firstDigit = 0,
            secondDigit = 0,
            beforeSum = 0;

        for (int i = 0; i < maxLength; i++)
        {
            if (numberOneLength != maxLength)
            {
                secondDigit = short.Parse(secondNumber[i]);

                if (i < numberOneLength)
                {
                    firstDigit = short.Parse(firstNumber[i]);
                }
                else
                {
                    firstDigit = 0;
                }
            }
            else
            {
                firstDigit = short.Parse(firstNumber[i]);

                if (i < numberTwoLength)
                {
                    secondDigit = short.Parse(secondNumber[i]);
                }
                else
                {
                    secondDigit = 0;
                }
            }

            short nextSum = (short)(firstDigit + secondDigit);
            if (beforeSum >= 10)
            {
                nextSum++;
            }
            if (nextSum >= 10)
            {
                result.Append(nextSum % 10);
                beforeSum = nextSum;
            }
            else
            {
                result.Append(nextSum);
                beforeSum = 0;
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        var lengths = Console.ReadLine().Split(' ');

        short numberOneLength = short.Parse(lengths[0]);
        short numberTwoLength = short.Parse(lengths[1]);

        var firstNumber = Console.ReadLine().Split(' ');
        var secondNumber = Console.ReadLine().Split(' ');

        var result = CalculateTwoNumbersRepresentedAsArrays(firstNumber, secondNumber, numberOneLength, numberTwoLength);

        PrintNumberSeparatedBySpacesToConsole(result);
    }
}

